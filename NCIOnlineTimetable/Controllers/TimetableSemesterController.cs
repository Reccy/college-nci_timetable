using NCIOnlineTimetable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace NCIOnlineTimetable.Controllers
{
    public class TimetableSemesterController : System.Web.Http.ApiController
    {
        [ResponseType(typeof(string))]
        public IHttpActionResult GET(string timetableId)
        {
            TimetableContext context = new TimetableContext();

            List<int> semesterId = context.Database.SqlQuery<int>(@"SELECT Semester_Id FROM Timetables WHERE Id = '" + timetableId + "';").ToList<int>();
            List<int> term = context.Database.SqlQuery<int>(@"SELECT Term FROM Semesters WHERE Id = '" + semesterId[0] + "';").ToList<int>();
            return Ok(term[0]);
        }
    }
}