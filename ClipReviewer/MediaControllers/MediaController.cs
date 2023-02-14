using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClipReviewer.MediaControllers
{
    public abstract class MediaController : IDisposable
    {
        public abstract Process? GetProcess();
        public abstract bool IsPlaying { get; }
        public abstract int Position { get; }

        public abstract void Play();
        public abstract void Stop();
        public abstract void Pause();
        public abstract void Add(string filename);
        //public abstract void Enqueue(string filename);
        public abstract void GoToFullscreen();
        public abstract void Seek(int time);

        internal Process? controllerProcess = null;
        internal TcpClient? controllerTcpClient = null;

        public virtual void Dispose()
        {
            try
            {
                if (controllerProcess != null)
                    controllerProcess.Kill();
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
