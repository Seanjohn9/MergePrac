using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;
using System.Diagnostics;

namespace MVC_Project.Controllers
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

        public IActionResult Winrev()
        {

            StudentModel student = new StudentModel();
            student.ID = 1;
            student.FirstName = "Winrev";
            student.MI = "Caballes";
            student.LastName = "Cruz";
            student.Hobbies = "Gaming,Gaming,Gaming,Gaming,Gaming,Gaming,Gaming,Gaming,Gaming,Gaming,Gaming";
            student.BirthDate = "April 23, 2007";

            ViewBag.WelcomeMessage = "Member 1";

            return View(student);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
