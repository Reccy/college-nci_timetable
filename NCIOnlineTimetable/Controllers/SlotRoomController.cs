using NCIOnlineTimetable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;

namespace NCIOnlineTimetable.Controllers
{
    public class SlotRoomController : System.Web.Http.ApiController
    {
        [ResponseType(typeof(string))]
        public IHttpActionResult GET(string slotId)
        {
            TimetableContext context = new TimetableContext();

            List<int> roomId = context.Database.SqlQuery<int>(@"SELECT Room_Id FROM Slots WHERE Id = '" + slotId + "';").ToList<int>();
            List<string> room = context.Database.SqlQuery<string>(@"SELECT Name FROM Rooms WHERE Id = '" + roomId[0] + "';").ToList<string>();

            return Ok(room[0]);
        }
    }
}