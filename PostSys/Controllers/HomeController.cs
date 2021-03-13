using System.Web.Mvc;

namespace PostSys.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles = "Admin, Marketing Coordinator, Marketing Manager, Student, Guest")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HomePage()
        {

            return View();
        }

        public ActionResult DashBoard()
        {

            return View();
        }
    }
}