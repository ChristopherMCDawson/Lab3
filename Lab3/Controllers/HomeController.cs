using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SongForm() => View();

        [HttpPost]
        public IActionResult Sing(IFormCollection collection)
        {
            ViewBag.monkeyCount = Int32.Parse(collection["monkey-count"]);
            return View("Sing");
        }

        public IActionResult CreateStudent() => View();

        [HttpPost]
        public IActionResult DisplayStudent(Person person)
        {
            ViewBag.person = person;
            return View("DisplayPerson");
        }
        public IActionResult Error()
        {
            return View();
        }

    }
}
