using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NCIOnlineTimetable.Models
{
    public class TimetableContext : DbContext
    {
        public TimetableContext() : base("name=DefaultConnection") {}

        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Timetable> Timetables { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}