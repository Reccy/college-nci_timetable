using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NCIOnlineTimetable.Models
{
    public class Timetable
    {
        private ICollection<Slot> _slots;
        
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Slot> Slots
        {
            get { return _slots as List<Slot>; }
            set { _slots = value; }
        }
        public bool IsCourse { get; set; }

        public Timetable()
        {
            _slots = new List<Slot>();
        }
    }
}