using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyPoc.Web.HttpClients;
using MyPoc.WebApp.Models;

namespace MyPoc.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebApi1Client webApi1;

        public HomeController(IWebApi1Client webApi1)
        {
            this.webApi1 = webApi1;
        }
        public async Task<IActionResult> Index()
        {
            ViewData["webapi1response"] = await webApi1.Get();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
