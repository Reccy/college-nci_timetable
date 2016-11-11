using NCIOnlineTimetable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NCIOnlineTimetable.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Floor(int id)
        {
            List<Timetable> room_timetables;

            if (id < 1)
                id = 1;
            else if (id > 3)
                id = 3;

            switch (id)
            {
                case 1:
                    room_timetables = new List<Timetable>
                    {
                        new Timetable { Id = 5, Name = "1.01 / SCR1", Slots = AggregateSlots("1.01 / SCR1"), IsCourse = false },
                        new Timetable { Id = 6, Name = "1.02", Slots = AggregateSlots("1.02"), IsCourse = false },
                        new Timetable { Id = 7, Name = "1.03", Slots = AggregateSlots("1.03"), IsCourse = false },
                        new Timetable { Id = 8, Name = "1.04", Slots = AggregateSlots("1.04"), IsCourse = false },
                        new Timetable { Id = 9, Name = "1.05", Slots = AggregateSlots("1.05"), IsCourse = false },
                        new Timetable { Id = 10, Name = "1.06", Slots = AggregateSlots("1.06"), IsCourse = false },
                        new Timetable { Id = 11, Name = "Theatre 1", Slots = AggregateSlots("Theatre 1"), IsCourse = false }
                    };
                    break;
                case 2:
                    room_timetables = new List<Timetable>
                    {
                        new Timetable { Id = 12, Name = "2.01 / SCR2", Slots = AggregateSlots("2.01 / SCR2"), IsCourse = false },
                        new Timetable { Id = 13, Name = "2.02", Slots = AggregateSlots("2.02"), IsCourse = false },
                        new Timetable { Id = 14, Name = "2.03", Slots = AggregateSlots("2.03"), IsCourse = false },
                        new Timetable { Id = 15, Name = "2.04", Slots = AggregateSlots("2.04"), IsCourse = false },
                        new Timetable { Id = 16, Name = "2.05", Slots = AggregateSlots("2.05"), IsCourse = false },
                        new Timetable { Id = 17, Name = "2.06", Slots = AggregateSlots("2.06"), IsCourse = false },
                        new Timetable { Id = 18, Name = "2.07", Slots = AggregateSlots("2.07"), IsCourse = false },
                        new Timetable { Id = 19, Name = "2.08", Slots = AggregateSlots("2.08"), IsCourse = false },
                        new Timetable { Id = 20, Name = "Theatre 2", Slots = AggregateSlots("Theatre 2"), IsCourse = false }
                    };
                    break;
                case 3:
                    room_timetables = new List<Timetable>
                    {
                        new Timetable { Id = 21, Name = "3.01 / SCR3", Slots = AggregateSlots("3.01 / SCR3"), IsCourse = false },
                        new Timetable { Id = 22, Name = "3.02", Slots = AggregateSlots("3.02"), IsCourse = false },
                        new Timetable { Id = 23, Name = "3.03", Slots = AggregateSlots("3.03"), IsCourse = false },
                        new Timetable { Id = 24, Name = "3.04", Slots = AggregateSlots("3.04"), IsCourse = false },
                        new Timetable { Id = 25, Name = "3.08", Slots = AggregateSlots("3.08"), IsCourse = false },
                        new Timetable { Id = 26, Name = "Theatre 3", Slots = AggregateSlots("Theatre 3"), IsCourse = false }
                    };
                    break;
                default:
                    room_timetables = new List<Timetable>
                    {
                        new Timetable { Id = 5, Name = "1.01 / SCR1", Slots = AggregateSlots("1.01 / SCR1"), IsCourse = false },
                        new Timetable { Id = 6, Name = "1.02", Slots = AggregateSlots("1.02"), IsCourse = false },
                        new Timetable { Id = 7, Name = "1.03", Slots = AggregateSlots("1.03"), IsCourse = false },
                        new Timetable { Id = 8, Name = "1.04", Slots = AggregateSlots("1.04"), IsCourse = false },
                        new Timetable { Id = 9, Name = "1.05", Slots = AggregateSlots("1.05"), IsCourse = false },
                        new Timetable { Id = 10, Name = "1.06", Slots = AggregateSlots("1.06"), IsCourse = false },
                        new Timetable { Id = 11, Name = "Theatre 1", Slots = AggregateSlots("Theatre 1"), IsCourse = false }
                    };
                    break;
            }

            ViewBag.Floor = id;
            ViewBag.Timetables = room_timetables;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public List<Slot> AggregateSlots(string roomName)
        {
            TimetableContext context = new TimetableContext();

            var query = from s in context.Slots
                        where s.Room.Name.Equals(roomName)
                        select s;

            List<Slot> slots = new List<Slot>();

            foreach (var result in query)
            {
                slots.Add(result);
            }

            return slots;
        }
    }
}