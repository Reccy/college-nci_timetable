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

            //
            //Rooms
            //

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

            //
            //Slots
            //

            //BIS 1 Semester 1
            var bis_1_1_slots = new List<Slot>
            {
                //Monday
                new Slot { Id = 1, Name = "Problem Solving and Programming Concepts", StartTime = 9, EndTime = 11, Day = Slot.Weekday.Monday, Room = rooms.First<Room>(s => s.Name == "1.01 / SCR1") },
                new Slot { Id = 2, Name = "Web Design", StartTime = 13, EndTime = 15, Day = Slot.Weekday.Monday, Room = rooms.First<Room>(s => s.Name == "1.01 / SCR1") },
                new Slot { Id = 3, Name = "Managing Your Learning", StartTime = 15, EndTime = 17, Day = Slot.Weekday.Monday, Room = rooms.First<Room>(s => s.Name == "2.05") },
                //Tuesday
                new Slot { Id = 4, Name = "Web Design", StartTime = 13, EndTime = 15, Day = Slot.Weekday.Tuesday, Room = rooms.First<Room>(s => s.Name == "3.08") },
                new Slot { Id = 5, Name = "The Computing Industry", StartTime = 15, EndTime = 17, Day = Slot.Weekday.Tuesday, Room = rooms.First<Room>(s => s.Name == "3.08") },
                //Wednesday
                new Slot { Id = 6, Name = "Introduction to Mathematics for Business & Computing", StartTime = 11, EndTime = 13, Day = Slot.Weekday.Wednesday, Room = rooms.First<Room>(s => s.Name == "1.01 / SCR1") },
                //Thursday
                new Slot { Id = 7, Name = "Problem Solving and Programming Concepts", StartTime = 9, EndTime = 11, Day = Slot.Weekday.Thursday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                new Slot { Id = 8, Name = "Introduction to Mathematics for Business & Computing", StartTime = 11, EndTime = 12, Day = Slot.Weekday.Thursday, Room = rooms.First<Room>(s => s.Name == "2.01 / SCR2") },
                new Slot { Id = 9, Name = "Web Design", StartTime = 13, EndTime = 15, Day = Slot.Weekday.Thursday, Room = rooms.First<Room>(s => s.Name == "3.08") },
                new Slot { Id = 10, Name = "The Computing Industry", StartTime = 15, EndTime = 17, Day = Slot.Weekday.Thursday, Room = rooms.First<Room>(s => s.Name == "3.08") },
            };

            bis_1_1_slots.ForEach(s => context.Slots.Add(s));

            //BIS 1 Semester 2
            var bis_1_2_slots = new List<Slot>
            {
                //Monday
                new Slot { Id = 11, Name = "Object Oriented Programming", StartTime = 9, EndTime = 11, Day = Slot.Weekday.Monday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                new Slot { Id = 12, Name = "Introduction to Databases", StartTime = 11, EndTime = 13, Day = Slot.Weekday.Monday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                //Tuesday
                new Slot { Id = 13, Name = "Fundamentals Business Analysis", StartTime = 9, EndTime = 10, Day = Slot.Weekday.Tuesday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                new Slot { Id = 14, Name = "Introduction to Databases", StartTime = 10, EndTime = 11, Day = Slot.Weekday.Tuesday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                new Slot { Id = 15, Name = "Information Technology Project Management", StartTime = 11, EndTime = 13, Day = Slot.Weekday.Tuesday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                new Slot { Id = 16, Name = "Web Application Development", StartTime = 15, EndTime = 17, Day = Slot.Weekday.Tuesday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                //Thursday
                new Slot { Id = 17, Name = "Fundamentals Business Analysis", StartTime = 11, EndTime = 13, Day = Slot.Weekday.Thursday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                new Slot { Id = 18, Name = "Web Application Development", StartTime = 15, EndTime = 17, Day = Slot.Weekday.Thursday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                //Friday
                new Slot { Id = 19, Name = "Object Oriented Programming", StartTime = 9, EndTime = 11, Day = Slot.Weekday.Friday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                new Slot { Id = 20, Name = "Web Application Development", StartTime = 13, EndTime = 15, Day = Slot.Weekday.Friday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                new Slot { Id = 21, Name = "Information Technology Project Management", StartTime = 15, EndTime = 16, Day = Slot.Weekday.Friday, Room = rooms.First<Room>(s => s.Name == "3.01 / SCR3") }
            };

            bis_1_2_slots.ForEach(s => context.Slots.Add(s));

            //BSHC 1 Semester 1
            var bshc_1_1_slots = new List<Slot>
            {
                //Monday
                new Slot { Id = 22, Name = "Web Design", StartTime = 13, EndTime = 15, Day = Slot.Weekday.Monday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                new Slot { Id = 23, Name = "Problem Solving and Programming Concepts", StartTime = 15, EndTime = 17, Day = Slot.Weekday.Monday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                //Tuesday
                new Slot { Id = 24, Name = "Managing Your Learning", StartTime = 11, EndTime = 13, Day = Slot.Weekday.Tuesday, Room = rooms.First<Room>(s => s.Name == "3.02") },
                new Slot { Id = 25, Name = "The Computing Industry", StartTime = 15, EndTime = 17, Day = Slot.Weekday.Tuesday, Room = rooms.First<Room>(s => s.Name == "3.02") },
                //Wednesday
                new Slot { Id = 26, Name = "Web Design", StartTime = 9, EndTime = 11, Day = Slot.Weekday.Wednesday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                new Slot { Id = 27, Name = "Introduction to Mathematics for Business & Computing", StartTime = 11, EndTime = 13, Day = Slot.Weekday.Wednesday, Room = rooms.First<Room>(s => s.Name == "3.01 / SCR3") },
                //Thursday
                new Slot { Id = 28, Name = "Web Design", StartTime = 13, EndTime = 15, Day = Slot.Weekday.Thursday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                new Slot { Id = 29, Name = "The Computing Industry", StartTime = 16, EndTime = 17, Day = Slot.Weekday.Thursday, Room = rooms.First<Room>(s => s.Name == "3.01 / SCR3") },
                //Friday
                new Slot { Id = 30, Name = "Introduction to Mathematics for Business & Computing", StartTime = 13, EndTime = 14, Day = Slot.Weekday.Friday, Room = rooms.First<Room>(s => s.Name == "3.01 / SCR3") },
                new Slot { Id = 31, Name = "Problem Solving and Programming Concepts", StartTime = 15, EndTime = 17, Day = Slot.Weekday.Friday, Room = rooms.First<Room>(s => s.Name == "3.03") }
            };

            bshc_1_1_slots.ForEach(s => context.Slots.Add(s));

            //BSHC 1 Semester 2
            var bshc_1_2_slots = new List<Slot>
            {
                //Monday
                new Slot { Id = 32, Name = "Object Oriented Programming", StartTime = 9, EndTime = 11, Day = Slot.Weekday.Monday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                new Slot { Id = 33, Name = "Introduction to Databases", StartTime = 11, EndTime = 13, Day = Slot.Weekday.Monday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                //Tuesday
                new Slot { Id = 34, Name = "Fundamentals Business Analysis", StartTime = 9, EndTime = 10, Day = Slot.Weekday.Tuesday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                new Slot { Id = 35, Name = "Introduction to Databases", StartTime = 10, EndTime = 11, Day = Slot.Weekday.Tuesday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                new Slot { Id = 36, Name = "Information Technology Project Management", StartTime = 11, EndTime = 13, Day = Slot.Weekday.Tuesday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                new Slot { Id = 37, Name = "Web Application Development", StartTime = 15, EndTime = 17, Day = Slot.Weekday.Tuesday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                //Thursday
                new Slot { Id = 38, Name = "Fundamentals Business Analysis", StartTime = 11, EndTime = 13, Day = Slot.Weekday.Thursday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                new Slot { Id = 39, Name = "Web Application Development", StartTime = 15, EndTime = 17, Day = Slot.Weekday.Thursday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                //Friday
                new Slot { Id = 40, Name = "Object Oriented Programming", StartTime = 9, EndTime = 11, Day = Slot.Weekday.Friday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                new Slot { Id = 41, Name = "Web Application Development", StartTime = 13, EndTime = 15, Day = Slot.Weekday.Friday, Room = rooms.First<Room>(s => s.Name == "3.03") },
                new Slot { Id = 42, Name = "Information Technology Project Management", StartTime = 15, EndTime = 16, Day = Slot.Weekday.Friday, Room = rooms.First<Room>(s => s.Name == "3.01 / SCR3") }
            };

            bshc_1_2_slots.ForEach(s => context.Slots.Add(s));

            //
            //Timetables
            //

            //Semester 1 Timetables
            var term1_timetables = new List<Timetable>
            {
                new Timetable { Id = 1, Name = "BIS 1 - Semester 1", Slots = bis_1_1_slots, IsCourse = true },
                new Timetable { Id = 2, Name = "BSHC 1 - Semester 1", Slots = bshc_1_1_slots, IsCourse = true }
            };

            term1_timetables.ForEach(s => context.Timetables.Add(s));

            //Semester 2 Timetables
            var term2_timetables = new List<Timetable>
            {
                new Timetable { Id = 3, Name = "BIS 1 - Semester 2", Slots = bis_1_2_slots, IsCourse = true },
                new Timetable { Id = 4, Name = "BSHC 2 - Semester 2", Slots = bshc_1_2_slots, IsCourse = true }
            };

            term2_timetables.ForEach(s => context.Timetables.Add(s));

            //
            //Semesters
            //

            var semesters = new List<Semester>
            {
                new Semester { Id = 1, Term = 1, Year = 2016, Timetables = term1_timetables },
                new Semester { Id = 2, Term = 2, Year = 2016, Timetables = term2_timetables }
            };

            semesters.ForEach(s => context.Semesters.Add(s));
            context.SaveChanges();
        }
    }
}
