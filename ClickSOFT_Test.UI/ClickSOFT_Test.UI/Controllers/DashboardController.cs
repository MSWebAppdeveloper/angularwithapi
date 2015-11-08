using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

using System.Web.Mvc;

namespace ClickSOFT_Test.UI.Controllers
{
    [RoutePrefix("dashboard")]
    public class DashboardController : Controller
    {

        [HttpGet]
       
        public ActionResult Index()
        {
            return View();
        }
    }
}
