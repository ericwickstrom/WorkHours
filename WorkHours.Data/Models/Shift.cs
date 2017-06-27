using System;
using System.Collections.Generic;
using System.Text;

namespace WorkHours.Data.Models
{
    public class Shift
    {
        public DateTime ScheduledStart { get; set; }
        public DateTime ScheduledEnd { get; set; }
        public DateTime ActualStart { get; set; }
        public DateTime ActualEnd { get; set; }
    }
}
