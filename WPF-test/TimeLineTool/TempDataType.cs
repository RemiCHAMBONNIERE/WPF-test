using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace TimeLineTool
{
	public class TempDataType : ITimeLineDataItem
	{
		public DateTime? StartTime { get; set; }
		public DateTime? EndTime { get; set; }
        public bool TimelineViewExpanded { get; set; }
		public string PUL { get; set; }
		public Brush Color { get; set; }
		public string SF { get; set; }
	}
}
