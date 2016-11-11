using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NCIOnlineTimetable.Models
{
    public class Slot
    {
        public enum Weekday { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

        public int Id { get; set; }
        public string Name { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public Weekday Day { get; set; }
        public Room Room { get; set; }
    }
}