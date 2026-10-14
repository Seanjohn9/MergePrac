using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Diagnostics;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Kirsten()
        {

            StudentModel student = new StudentModel();
            student.ID = "2025-01281-MN-0";
            student.FirstName = "Kirsten Angela";
            student.MiddleName = "Borbe";
            student.LastName = "Linga";
            student.Address = "Dalig Antipolo City";

            ViewBag.WelcomeMessage = "MEMBER 2";
            ViewData["Quote"] = "Shibal";

            return View(student);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
