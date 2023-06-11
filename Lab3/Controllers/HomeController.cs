using Microsoft.AspNetCore.Mvc;
using System;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult SongForm() => View();

        [HttpPost]
        public IActionResult Sing(int monkeys)
        {
            if (monkeys >= 50 && monkeys <= 100)
            {
                HttpContext.Session.SetInt32("Monkeys", monkeys);
                return RedirectToAction("Sing");
            }
            else
            {
                ModelState.AddModelError("", "Please enter a number between 50 and 100.");
                return View("SongForm", monkeys);
            }
        }
        public IActionResult Sing()
        {
            int? monkeys = HttpContext.Session.GetInt32("Monkeys");
            ViewBag.Monkeys = monkeys ?? 0;
            return View();
        }

        public IActionResult CreatePerson() => View();

        [HttpPost]
        public IActionResult DisplayPerson(Person person)
        {
            // you will complete this
        }
        public IActionResult Error()
        {
            return View();
        }




    }







}
