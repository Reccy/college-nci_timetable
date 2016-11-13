using NCIOnlineTimetable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace NCIOnlineTimetable.Controllers
{
    public class SlotCourseController : System.Web.Http.ApiController
    {
        [ResponseType(typeof(string))]
        public IHttpActionResult GET(string slotId)
        {
            TimetableContext context = new TimetableContext();

            List<int> slot = context.Database.SqlQuery<int>(@"SELECT Timetable_Id FROM Slots WHERE Id = '" + slotId + "';").ToList<int>();
            List<string> course = context.Database.SqlQuery<string>(@"SELECT Name FROM Timetables WHERE Id = '" + slot[0] + "';").ToList<string>();

            return Ok(course[0]);
        }
    }
}