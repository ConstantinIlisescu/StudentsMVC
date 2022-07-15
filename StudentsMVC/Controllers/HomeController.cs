using StudentsMVC.Models;
using System.Collections.Generic;
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

        public ActionResult Instructor(int id = 1)
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
            List<Instructor> instructors = new List<Instructor>()
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Coste",
                    LastName = "Ilisescu"

                },
                new Instructor
                {
                    Id = 2,
                    FirstName = "Lavi",
                    LastName = "Ilisescu"

                },
                new Instructor
                {
                    Id = 3,
                    FirstName = "Maria",
                    LastName = "Ilisescu"

                }
            };
            return View(instructors);
        }
    }
}