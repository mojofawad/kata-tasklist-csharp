using System;
using System.Collections.Generic;

namespace Tasks
{
    public class Task
    {
        public long Id { get; set; }

        public string Description { get; set; }

        private bool done;
        public bool Done => done;

        public void MarkDone()
        {
            done = true;
        }

        public void MarkNotDone()
        {
            done = false;
        }
    }
}