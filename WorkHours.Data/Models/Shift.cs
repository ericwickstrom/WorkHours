using System;
using System.Collections.Generic;
using System.Text;

namespace WorkHours.Data.Models
{
    public class Shift
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
