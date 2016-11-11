namespace NCIOnlineTimetable.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NCIOnlineTimetable.Models.TimetableContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NCIOnlineTimetable.Models.TimetableContext context)
        {
            var rooms = new List<Room>
            {
                //Floor 1
                new Room { Id = 1, Floor = 1, Name = "1.01 / SCR1" },
                new Room { Id = 2, Floor = 1, Name = "1.02" },
                new Room { Id = 3, Floor = 1, Name = "1.03" },
                new Room { Id = 4, Floor = 1, Name = "1.04" },
                new Room { Id = 5, Floor = 1, Name = "1.05" },
                new Room { Id = 6, Floor = 1, Name = "1.06" },
                new Room { Id = 7, Floor = 1, Name = "Theatre 1" },
                //Floor 2
                new Room { Id = 8, Floor = 2, Name = "2.01 / SCR2" },
                new Room { Id = 9, Floor = 2, Name = "2.02" },
                new Room { Id = 10, Floor = 2, Name = "2.03" },
                new Room { Id = 11, Floor = 2, Name = "2.04" },
                new Room { Id = 12, Floor = 2, Name = "2.05" },
                new Room { Id = 13, Floor = 2, Name = "2.06" },
                new Room { Id = 14, Floor = 2, Name = "2.08" },
                new Room { Id = 15, Floor = 2, Name = "Theatre 2" },
                //Floor 3
                new Room { Id = 16, Floor = 3, Name = "3.01 / SCR3" },
                new Room { Id = 17, Floor = 3, Name = "3.02" },
                new Room { Id = 18, Floor = 3, Name = "3.03" },
                new Room { Id = 19, Floor = 3, Name = "3.04" },
                new Room { Id = 20, Floor = 3, Name = "3.08" },
                new Room { Id = 21, Floor = 3, Name = "Theatre 3" }
            };

            rooms.ForEach(s => context.Rooms.Add(s));
            context.SaveChanges();

            //BIS 1
            var bis_1_slots = new List<Slot>
            {
                //Monday
                new Slot { Id = 1, StartTime = 9, EndTime = 11, Day = Slot.Weekday.Monday, Room = rooms.First<Room>(s => s.Name == "1.01 / SCR1") },
                new Slot { Id = 2, StartTime = 13, EndTime = 15, Day = Slot.Weekday.Monday, Room = rooms.First<Room>(s => s.Name == "1.01 / SCR1") },
                new Slot { Id = 3, StartTime = 15, EndTime = 17, Day = Slot.Weekday.Monday, Room = rooms.First<Room>(s => s.Name == "2.05") },
                //Tuesday
                new Slot { Id = 5, StartTime = 13, EndTime = 15, Day = Slot.Weekday.Tuesday, Room = rooms.First<Room>(s => s.Name == "3.08") },
                new Slot { Id = 6, StartTime = 15, EndTime = 17, Day = Slot.Weekday.Tuesday, Room = rooms.First<Room>(s => s.Name == "3.08") },
                //Wednesday
                new Slot { Id = 7, StartTime = 11, EndTime = 13, Day = Slot.Weekday.Wednesday, Room = rooms.First<Room>(s => s.Name == "1.01 / SCR1") },
                //Thursday
                new Slot { Id = 7, StartTime = 9, EndTime = 11, Day = Slot.Weekday.Thursday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                new Slot { Id = 7, StartTime = 11, EndTime = 12, Day = Slot.Weekday.Thursday, Room = rooms.First<Room>(s => s.Name == "2.01 / SCR2") },
                new Slot { Id = 7, StartTime = 13, EndTime = 15, Day = Slot.Weekday.Thursday, Room = rooms.First<Room>(s => s.Name == "3.08") },
                new Slot { Id = 7, StartTime = 15, EndTime = 17, Day = Slot.Weekday.Thursday, Room = rooms.First<Room>(s => s.Name == "3.08") },
            };

            bis_1_slots.ForEach(s => context.Slots.Add(s));
            context.SaveChanges();

            var term1_timetables = new List<Timetable>
            {
                new Timetable { Id = 1, Name = "BIS 1", Slots = bis_1_slots, IsCourse = true }
            };

            term1_timetables.ForEach(s => context.Timetables.Add(s));
            context.SaveChanges();

            var semesters = new List<Semester>
            {
                new Semester { Id = 1, Term = 1, Year = 2016 }
            };

            semesters.ForEach(s => context.Semesters.Add(s));
            context.SaveChanges();
        }
    }
}
