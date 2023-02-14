using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipReviewer.MediaControllers
{
    public abstract class MediaController
    {
        public abstract Process? PlaybackProcess { get; }
        public abstract bool IsPlaying { get; }
        public abstract int Position { get; }
        public abstract void Play();
        public abstract void Stop();
        public abstract void Pause();
        public abstract void Add(string filename);
        //public abstract void Enqueue(string filename);
        public abstract void GoToFullscreen();
        public abstract void Seek(int time);
    }
}
