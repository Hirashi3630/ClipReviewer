using System.Runtime.InteropServices;
using System.Threading;
using Xabe.FFmpeg.Downloader;
using Xabe.FFmpeg;
using ClipReviewer.Utils;

namespace ClipReviewer
{
    internal static class Program
    {
#if DEBUG
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
#endif

        // https://stackoverflow.com/a/6486819/10806542
        static Mutex mutex = new Mutex(false, "Hirashi3630-ClipReviewer");

        private static async Task DownloadFFmpeg()
        {
            string ffmpegDir = Path.Combine(AppContext.BaseDirectory, "FFmpeg");
            if (!Directory.Exists(ffmpegDir))
                Directory.CreateDirectory(ffmpegDir);
            if (!File.Exists(Path.Combine(ffmpegDir, "ffmpeg.exe")))
            {
                Console.WriteLine("Downloading FFmpeg, please wait...");
                if (MsgBox.Info(
                    "The application needs to download FFmpeg (~75MB)\r\n" +
                    "Application will start automatically as soon as it finishes!",
                    buttons: MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    Environment.Exit(-1);
                await FFmpegDownloader.GetLatestVersion(FFmpegVersion.Full, ffmpegDir, null);
                Console.WriteLine("FFmpeg downloaded!");
                MsgBox.Info("FFmpeg was downloaded successfully!");
            }

            if (!File.Exists(Path.Combine(ffmpegDir, "ffmpeg.exe")) ||
                !File.Exists(Path.Combine(ffmpegDir, "ffprobe.exe")))
                throw new Exception("Unable to download FFmpeg! Check your internet connection or download manually to /FFmpeg folder!");

            FFmpeg.SetExecutablesPath(ffmpegDir);
        }

        [STAThread]
        static void Main()
        {
            if (!mutex.WaitOne(TimeSpan.FromSeconds(1), false))
            {
                MsgBox.Error(
                    "   Application is already running!\r\n" +
                    "   Only One instance of ClipReviewer can run at the same time!",
                    "Instance Issue");
                return;
            }

#if DEBUG
            AllocConsole();
            Console.WriteLine(
                "+----------------------------------------+\r\n" +
                "|                                        |\r\n" +
                "|          THIS IS DEBUG BUILD!          |\r\n" +
                "|  IF YOU ARE NOT SURE WHICH ONE TO USE  |\r\n" +
                "|   DOWNLOAD BUILD MARKED AS A RELEASE   |\r\n" +
                "|   /Hirashi3630/ClipReviewer/releases   |\r\n" +
                "|                                        |\r\n" +
                "+----------------------------------------+");
#endif
            // try to download ffmpeg
            try
            {
                Task.Run(() => DownloadFFmpeg()).Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Application will exit, waiting for any key press...");
                Console.ReadKey();
                MsgBox.Error("Error occured!\r\n" + ex.Message);
                return;
            }

            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new frmMain());
            }
            finally { mutex.ReleaseMutex(); } // I find this more explicit
        }
    }
}