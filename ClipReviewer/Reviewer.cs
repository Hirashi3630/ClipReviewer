using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipReviewer
{
    public class Reviewer
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
                    OnReviewStateChanged.Invoke(value);
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
                    OnClipsChanged.Invoke(value);
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
                    OnSelectedClipIndexChanged.Invoke(value);
            }
        }

        private ReviewerState m_State = ReviewerState.Unknown;
        public List<Clip> m_Clips = new List<Clip>();
        private int m_SelectedClipIndex;
        
        public Action<ReviewerState> OnReviewStateChanged = delegate { };
        public Action<List<Clip>> OnClipsChanged = delegate { };
        public Action<int> OnSelectedClipIndexChanged = delegate { };
        
        public Reviewer(List<Clip> clips, ReviewerState state = ReviewerState.Stopped, int selectedClipIndex = -1)
        {
            State = state;
            Clips = clips;
            SelectedClipIndex = selectedClipIndex;
        }
        #endregion

        public bool SelectNext() => Select(SelectedClipIndex + 1);
        public bool Select(int index)
        {
            if (Clips == null) throw new NullReferenceException(nameof(Clips));
            if (State != ReviewerState.Reviewing) return false;
            var clipsCount = Clips.Count;
            if (clipsCount <= 0 || index < 0 || index >= clipsCount) return false;

            SelectedClipIndex = index;
            return true;
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
