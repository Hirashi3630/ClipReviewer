using ClipReviewer.Utils;
using System.Diagnostics;
using System.Net.Sockets;

namespace ClipReviewer.MediaControllers
{
    public abstract class MediaController : IDisposable
    {
        public abstract Process? GetProcess();
        public abstract bool StartProcess();
        public virtual bool StopProcess()
        {
            try
            {
                if (controllerProcess != null)
                {
                    controllerProcess.Kill();
                    controllerProcess.Dispose();
                    if (!controllerProcess.IsRunning())
                        controllerProcess = null;
                }
                if (controllerTcpClient != null)
                {
                    controllerTcpClient.Close();
                    controllerTcpClient.Dispose();
                    controllerTcpClient = null;
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public abstract bool IsPlaying { get; }
        public abstract string CurrentlyPlaying { get; }
        public abstract int Position { get; }

        public abstract void Play();
        public abstract bool Play(string filename);
        public abstract void Stop();
        public abstract void Pause();
        //public abstract void Enqueue(string filename);
        public abstract void Fullscreen(bool value);
        public abstract bool Seek(int time);
        public abstract void Loop(bool value);

        protected string? controllerProcessExePath = null;
        protected Process? controllerProcess = null;
        protected TcpClient? controllerTcpClient = null;

        public bool Focus()
        {
            if (controllerProcess == null) return false;
            controllerProcess.BringToForeground();
            return true;
        }

        public virtual void Dispose()
        {
            try
            {
                StopProcess();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
