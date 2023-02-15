using ClipReviewer.Utils;
using System.Diagnostics;
using System.Net.Sockets;

namespace ClipReviewer.MediaControllers
{
    public abstract class MediaController : IDisposable
    {
        public abstract Process? GetProcess();
        public abstract bool IsPlaying { get; }
        public abstract string WhatIsPlaying { get; }
        public abstract int Position { get; }

        public abstract void Play();
        public abstract void Stop();
        public abstract void Pause();
        public abstract bool Add(string filename);
        //public abstract void Enqueue(string filename);
        public abstract void Fullscreen(bool value);
        public abstract bool Seek(int time);
        public abstract void Loop(bool value);

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
                if (controllerProcess != null)
                {
                    controllerProcess.Kill();
                    controllerProcess.Dispose();
                }
                if (controllerTcpClient != null)
                    controllerTcpClient.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
