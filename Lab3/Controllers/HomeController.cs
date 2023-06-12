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

        [HttpPost]//Add this the support for the Post method here so that the monkey count can be updated.
        public IActionResult Sing(IFormCollection collection)
        {
            ViewBag.monkeyCount = Int32.Parse(collection["monkey-count"]);// Count the monkeys
            return View("Sing");
        }

        public IActionResult CreatePerson() => View();

        [HttpPost]//Add this so that the person data can be added to a person entity and update it.
        public IActionResult DisplayPerson(Person person)
        {
            ViewBag.person = person;// Show the person.
            return View("DisplayPerson");
        }
        public IActionResult Error()
        {
            return View();
        }

    }
}
