using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab_81.Models;

namespace lab_81.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Test1()
        {
            //ViewData["Message"] = "Your application description page.";
            ViewBag.num1 = 10;
            ViewBag.num2 = 20;
            ViewBag.sum = (10 + 20);
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult user_registration()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Test2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Test2(string num1,string num2)
        {
            int ans = Int32.Parse(num1) + Int32.Parse(num2);
            ViewBag.answer = ans;
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
