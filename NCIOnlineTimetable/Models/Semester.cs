using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NCIOnlineTimetable.Models
{
    public class Semester
    {
        private ICollection<Timetable> _timetables;

        public Semester()
        {
            _timetables = new List<Timetable>();
        }

        public int Id { get; set; }
        public int Year { get; set; }
        public int Term { get; set; }
        public List<Timetable> Timetables
        {
            get { return _timetables as List<Timetable>; }
            set { _timetables = value; }
        }
    }
}