using ClipReviewer.Properties;
using ClipReviewer.Utils;
using Force.Crc32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using Xabe.FFmpeg;

namespace ClipReviewer
{
    public class Clip
    {
        public static string THUMBNAIL_PATH = Path.Combine(Path.GetTempPath(), "ClipReviewer_Thumbnails");

        public uint ID { get; set; }
        public string FileName => Path.GetFileName(FullFilePath);
        public DateTime CreatedDate => File.GetCreationTime(FullFilePath);
        public TimeSpan VideoDuration { get; }
        public string Category { get; private set; }
        public string Description { get; private set; }
        public string FullFilePath { get; }
        public string ThumbnailPath { get; private set; }

        public static async Task<Clip> New(string fullFilePath, 
            uint id = 0, string category = "", string description = "")
        {
            // --- hash ---
            // TODO: faster hash or something similar
            //var hash = GetCRC32C(fullFilePath);
            //string thumbnailPath = Path.Combine(Path.GetTempPath(), hash + ".png");

            // --- video duration ---
            IMediaInfo mediaInfo = await FFmpeg.GetMediaInfo(fullFilePath);
            TimeSpan videoDuration = mediaInfo.VideoStreams.First().Duration;

            // --- Thumbnail Generator ---
            string thumbnailPath = "";
            if (Settings.Default.ThumbGenEnabled)
            {
                //string output = Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".png");
                thumbnailPath = Path.Combine(THUMBNAIL_PATH, Path.GetFileNameWithoutExtension(fullFilePath) + ".jpg");
                
                var snapAt = TimeSpan.FromMilliseconds(Settings.Default.ThumbGenTime.ParseCustomTime(videoDuration.Milliseconds));

                if (File.Exists(thumbnailPath) && !Settings.Default.ThumbGenUseCached)
                    File.Delete(thumbnailPath);

                if (!File.Exists(thumbnailPath))
                {
                    try
                    {
                        if (snapAt > videoDuration)
                        {
                            snapAt = videoDuration / 2;
                            if (!Settings.Default.ThumbGenIgnoreWarning)
                                MsgBox.Warning(
                                    $"\"{Path.GetFileName(fullFilePath)}\" was shorter than SnapTo value!\r\n" +
                                    $"Consider setting percentage instead of absolute values in the settings.\r\n\r\n" +
                                    $"(You can disable this warning in the settings)", buttons: MessageBoxButtons.OK);
                        }
                        IConversion conversion = await FFmpeg.Conversions.FromSnippet.Snapshot(fullFilePath, thumbnailPath, snapAt);
                        IConversionResult result = await conversion.Start();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            // --- create instance ---
            return new Clip(id, fullFilePath, videoDuration, category, description, thumbnailPath);
        }
        
        private Clip(uint id, string fullFilePath, TimeSpan videoDuration, string category = "", string description = "", string thumbnailPath = "")
        {
            ID = id;
            FullFilePath = fullFilePath;
            VideoDuration = videoDuration;
            Category = category;
            Description = description;
            ThumbnailPath = thumbnailPath;
        }

        public void SetCategory(string cat)
        {
            Category = cat;
        }

        public void SetDescription(string desc)
        {
            Description = desc;
        }

        private static string GetCRC32C(string filename, IProgress<double> progress = null)
        {
            uint hash = 0;
            byte[] buffer = new byte[1048576]; // 1MB buffer

            using (var entryStream = File.OpenRead(filename))
            {
                int currentBlockSize = 0;

                while ((currentBlockSize = entryStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    hash = Crc32CAlgorithm.Append(hash, buffer, 0, currentBlockSize);
                    progress?.Report((double)currentBlockSize / entryStream.Length * 100);
                }
            }
            return hash.ToString("X8");
        }

        public override string ToString()
        {
            return $"{ID}. {FileName} ({FullFilePath})";
        }
    }
}
