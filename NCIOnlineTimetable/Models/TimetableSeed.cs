using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NCIOnlineTimetable.Models
{
    public class TimetableSeed : System.Data.Entity.DropCreateDatabaseIfModelChanges<TimetableContext>
    {
        protected override void Seed(TimetableContext context)
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

            var slots = new List<Slot>
            {
                //BIS 1
                //Monday
                new Slot { Id = 1, StartTime = new DateTime(0, 0, 0, 9, 0, 0), EndTime = new DateTime(0, 0, 0, 11, 0, 0), Room = rooms.First<Room>(s => s.Name == "1.01 / SCR1") }
            };

            slots.ForEach(s => context.Slots.Add(s));
            context.SaveChanges();
        }
    }
}