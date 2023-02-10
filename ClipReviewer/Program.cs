using System.Runtime.InteropServices;
using System.Threading;
using Xabe.FFmpeg.Downloader;
using Xabe.FFmpeg;

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

        private static void DownloadFFmpeg()
        {
            string ffmpegDir = Path.Combine(AppContext.BaseDirectory, "FFmpeg");
            if (!Directory.Exists(ffmpegDir))
                Directory.CreateDirectory(ffmpegDir);
            if (!File.Exists(Path.Combine(ffmpegDir, "ffmpeg.exe")))
                FFmpegDownloader.GetLatestVersion(FFmpegVersion.Full, ffmpegDir, null);

            if (!File.Exists(Path.Combine(ffmpegDir, "ffmpeg.exe")) ||
                !File.Exists(Path.Combine(ffmpegDir, "ffprobe.exe")))
                throw new Exception("Unable to download ffmpeg! Check your internet connection or download manually to /ffmpeg folder!");

            FFmpeg.SetExecutablesPath(ffmpegDir);
        }

        [STAThread]
        static void Main()
        {
            if (!mutex.WaitOne(TimeSpan.FromSeconds(1), false))
            {
                MessageBox.Show(
                    "   Application is already running!\r\n" +
                    "   Only One instance of ClipReviewer can run at the same time!",
                    "Instance Issue", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                DownloadFFmpeg();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Application will exit, waiting for any key press...");
                Console.ReadKey();
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