using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebRole.Controllers.WebApi
{
    public class UsersController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Json(new string[] { "Richard" });
        }
    }
}