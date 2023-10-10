using AspLesson8._1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspLesson8._1.Controllers
{
    public class HomeController : Controller
    {
        List<string> courses;
        SelectList selects;

        public HomeController()
        {
            courses = new List<string>() { "JavaScript", "C#", "Java", "Python", "Основы" };
            selects = new SelectList(courses, courses[1]);
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Consultation()
        {
            ViewBag.Selects = selects;
            return View();
        }
        [HttpPost]
        public IActionResult Consultation(Client client)
        {
            if (client.Course == "Основы")
            {
                if (client.DateOfVisit.DayOfWeek == DayOfWeek.Monday)
                {
                    ModelState.AddModelError(nameof(client.DateOfVisit), "Даний курс не працює по понеділкам");
                }
            }
            if (ModelState.IsValid)
            {
                return View("Success", client);
            }
            ViewBag.Selects = selects;
            return View(client);
        }
    }
}
