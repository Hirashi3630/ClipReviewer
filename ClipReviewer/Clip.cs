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
        public uint ID { get; private set; }
        public string FileName => Path.GetFileName(FullFilePath);
        public DateTime CreatedDate => File.GetCreationTime(FullFilePath);
        public string Category { get; private set; }
        public string Description { get; private set; }
        public string FullFilePath { get; private set; }
        public string ThumbnailPath { get; set; }

        public static async Task<Clip> New(uint id, string fullFilePath, string category = "", string description = "")
        {
            //string output = Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".png");
            string thumbnailPath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(fullFilePath) + ".png");
            // TODO: faster hash or something similar
            //var hash = GetCRC32C(fullFilePath);
            //string thumbnailPath = Path.Combine(Path.GetTempPath(), hash + ".png");

            if (!File.Exists(thumbnailPath))
            {
                try
                {
                    IMediaInfo mediaInfo = await FFmpeg.GetMediaInfo(fullFilePath);
                    var videoDuration = mediaInfo.VideoStreams.First().Duration;
                    Console.WriteLine(videoDuration);
                    IConversion conversion = await FFmpeg.Conversions.FromSnippet.Snapshot(fullFilePath, thumbnailPath, TimeSpan.FromSeconds(19));
                    IConversionResult result = await conversion.Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return new Clip(id, fullFilePath, category, description, thumbnailPath);
        }
        
        private Clip(uint id, string fullFilePath, string category = "", string description = "", string thumbnailPath = "")
        {
            ID = id;
            FullFilePath = fullFilePath;
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
