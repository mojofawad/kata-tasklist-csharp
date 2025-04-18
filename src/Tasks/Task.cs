using System;
using System.Collections.Generic;

namespace Tasks
{
	public class Task
	{
		public long Id { get; set; }

		public string Description { get; set; }

		public bool Done { get; set; }

		public void MarkDone()
		{
			throw new NotImplementedException();
		}

		public void MarkNotDone()
		{
			throw new NotImplementedException();
		}
	}
}
