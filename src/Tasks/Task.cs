using System;

namespace Tasks
{
    public class Task
    {
        private readonly long _id;
        private readonly string _description;
        private bool _done;
        private DateOnly? _deadline;

        public Task(long id, string description)
        {
            _id = id;
            _description = description;
            _done = false;
        }


        public long Id => _id;
        public string Description => _description;
        public bool Done => _done;
        public DateOnly? Deadline => _deadline;

        public void MarkDone()
        {
            _done = true;
        }

        public void MarkNotDone()
        {
            _done = false;
        }

        public void SetDeadline(DateOnly deadline)
        {
            _deadline = deadline;
        }
    }
}