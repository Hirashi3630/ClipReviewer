using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipReviewer
{
    public class Reviewer
    {
        public ReviewerState State { get; set; }

        public enum ReviewerState
        {
            Unknown = 0,
            Stopped = 1,
            Reviewing = 2,
            Paused = 3,
        }
    }
    
}
