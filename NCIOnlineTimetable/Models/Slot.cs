using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NCIOnlineTimetable.Models
{
    public class Slot
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Room Room { get; set; }
    }
}