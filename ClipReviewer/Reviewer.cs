using ClipReviewer.MediaControllers;
using ClipReviewer.Properties;
using ClipReviewer.Utils;
using System.Diagnostics;

namespace ClipReviewer
{
    public class Reviewer : IDisposable
    {
        #region Properties
        public ReviewerState State
        {
            get => m_State;
            set
            {
                var old = m_State;
                m_State = value;
                if (OnReviewStateChanged != null && old != value)
                    OnReviewStateChanged.Invoke(old, value);
            }
        }
        public List<Clip> Clips
        {
            get => m_Clips;
            set
            {
                var old = m_Clips;
                m_Clips = value;
                if (OnClipsChanged != null && old != value)
                    OnClipsChanged.Invoke(old, value);
            }
        }
        public int SelectedClipIndex
        {
            get => m_SelectedClipIndex;
            private set
            {
                var old = m_SelectedClipIndex;
                m_SelectedClipIndex = value;
                if (OnSelectedClipIndexChanged != null && old != value)
                    OnSelectedClipIndexChanged.Invoke(old, value);
            }
        }

        private ReviewerState m_State = ReviewerState.Unknown;
        public List<Clip> m_Clips = new List<Clip>();
        private int m_SelectedClipIndex;

        public Action<ReviewerState, ReviewerState> OnReviewStateChanged = delegate { };
        public Action<List<Clip>, List<Clip>> OnClipsChanged = delegate { };
        public Action<int, int> OnSelectedClipIndexChanged = delegate { };
        #endregion

        private MediaController mediaController;

        public Reviewer(List<Clip> clips, MediaController controller, ReviewerState state = ReviewerState.Stopped, int selectedClipIndex = -1)
        {
            this.State = state;
            this.Clips = clips;
            this.SelectedClipIndex = selectedClipIndex;
            this.mediaController = controller;
            OnReviewStateChanged += HandleStateChanged;
            OnClipsChanged += HandleClipsChanged;
            OnSelectedClipIndexChanged += HandleSelectedIndexChanged;
        }

        public void Dispose()
        {
            if (mediaController != null) mediaController.Dispose();
        }

        public bool SelectNext()
        {
            var newIndex = SelectedClipIndex + 1;
            return Select(newIndex >= Clips.Count ? 0 : newIndex); 
        }

        public bool Select(int index)
        {
            if (Clips == null) throw new NullReferenceException(nameof(Clips));
            //if (State != ReviewerState.Reviewing) return false;
            var clipsCount = Clips.Count;
            if (clipsCount <= 0 || index < 0 || index >= clipsCount) return false;

            SelectedClipIndex = index;
            return true;
        }

        private void HandleStateChanged(ReviewerState oldState, ReviewerState newState)
        {
            Task.Run(ReviewLoop).ContinueWith((x) => Console.WriteLine("Loop ended"));
        }

        private Process? StartMediaController()
        {
            mediaController.StartProcess();
            var p = mediaController.GetProcess();
            if (p != null && p.IsRunning())
            {
                Console.WriteLine("Index Result: " + SelectedClipIndex);
                Console.WriteLine("Focus result " + mediaController.Focus());
                mediaController.Loop(true);
                if (Settings.Default.ClipsReviewFullscreen)
                    mediaController.Fullscreen(true);
                return p;
            }
            else
            {
                Console.WriteLine("Can't start media process!");
                return null;
            }
        }
        private void StopMediaController()
        {
            mediaController.StopProcess();
            State = ReviewerState.Stopped;
        }

        private bool isReviewLoopRunning = false;
        private async Task ReviewLoop()
        {
            if (isReviewLoopRunning) return;
            isReviewLoopRunning = true;

            Process? p = null;

            while (State == ReviewerState.Reviewing)
            {
                try
                {
                    if (p == null)
                    {
                        p = StartMediaController();
                        Console.WriteLine("Add result " + mediaController.Play(Clips[SelectedClipIndex].FullFilePath));
                        Console.WriteLine("Currently Playing: " + mediaController.CurrentlyPlaying);
                    }

                    // loop start

                    await Task.Delay(500);
                    // loop end
                }
                catch (Exception ex)
                {
                    var isRunningMsg = "MediaController process is{0} running";
                    if (p == null)
                        p = mediaController.GetProcess();
                    if (p != null)
                        isRunningMsg = string.Format(isRunningMsg, (p.IsRunning() ? " NOT" : ""));
                    Console.WriteLine(isRunningMsg);
                    Console.WriteLine("Error: " + ex.Message);

                    State = ReviewerState.Stopped;
                    return;
                }
            }
            StopMediaController();
            isReviewLoopRunning = false;
        }

        private void HandleClipsChanged(List<Clip> oldClips, List<Clip> newClips)
        {

        }

        private void HandleSelectedIndexChanged(int oldIndex, int newIndex)
        {
            if (State == ReviewerState.Reviewing && mediaController != null)
            {
                mediaController.Play(Clips[newIndex].FullFilePath);
            }
        }
    }

    public enum ReviewerState
    {
        Unknown = 0,
        Stopped = 1,
        Reviewing = 2,
        Paused = 3,
    }
}
