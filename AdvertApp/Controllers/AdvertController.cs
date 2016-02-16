using Repositories;
using System.Web.Mvc;

namespace AdvertApp.Controllers
{
    public class AdvertController : Controller
    {
        // GET: Advert
        public ActionResult Index()
        {
            
            return View();
        }
    }
}