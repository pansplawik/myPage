using System.Web.Mvc;

namespace cv.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Dawno, dawno temu.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Kontakt.";

            return View();
        }
        public ActionResult MyCV()
        {
            return View();
        }
    }
}