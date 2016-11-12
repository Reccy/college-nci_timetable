using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace NCIOnlineTimetable.Controllers
{
    public class TimetablesController : System.Web.Http.ApiController
    {
        public IHttpActionResult GET(string timetableName)
        {
            return Ok("okay");
        }
    }
}