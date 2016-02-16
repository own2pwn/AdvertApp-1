using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdvertApp.Controllers
{
    public class LogoController : Controller
    {
        // GET: Logo
        public ActionResult Index()
        {
            var repsitory = new UserRepository();
            repsitory.Save(new Models.DataBaseModels.User { Email = "qe@qwe.qe", Login = "qwe", Name = "qe@qwe.qe", Password = "qwe", Phone = "qwe" });


            return View();
        }
    }
}