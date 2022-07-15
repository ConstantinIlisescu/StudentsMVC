using StudentsMVC.Models;
using System.Web.Mvc;

namespace StudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page - Academy of Learning.";

            return View();
        }

        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;
            Instructor dayTimeinstructor = new Instructor
            {
                Id = 1,
                FirstName = "Coste",
                LastName = "Ilisescu"

            };

            return View(dayTimeinstructor);
        }

        public ActionResult Instructors()
        {
            return View();
        }
    }
}