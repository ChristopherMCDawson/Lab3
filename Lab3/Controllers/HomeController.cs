using Lab3.Models;
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
            try
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
            catch (Exception)
            {
                ViewBag.ErrorMessage = "An error occurred while processing your request.";
                // Log the exception or perform additional error handling if needed
                return View("Error");
            }

        }
        public IActionResult Sing()
        {
            int? monkeys = HttpContext.Session.GetInt32("Monkeys");
            ViewBag.Monkeys = monkeys ?? 0;
            return View();
        }

        public IActionResult CreatePerson()
        {
            try
            {
                return View();
            }
            catch (Exception)
            {
                ViewBag.ErrorMessage = "An error occurred while processing your request.";
                // Log the exception or perform additional error handling if needed
                return View("Error");
            }
        }

        [HttpPost]
        public IActionResult DisplayPerson(Person person)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("DisplayPerson", person);
                }

                return View(person);
            }
            catch (Exception)
            {
                ViewBag.ErrorMessage = "An error occurred while processing your request.";
                // Log the exception or perform additional error handling if needed
                return View("Error");
            }


        }


    }




}
