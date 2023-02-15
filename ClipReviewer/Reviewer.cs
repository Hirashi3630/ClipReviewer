using ClipReviewer.MediaControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool SelectNext() => Select(SelectedClipIndex + 1);
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

        }
        private void HandleClipsChanged(List<Clip> oldClips, List<Clip> newClips)
        {

        }

        private void HandleSelectedIndexChanged(int oldIndex, int newIndex)
        {

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
