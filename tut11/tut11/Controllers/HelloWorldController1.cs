using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace tut11.Controllers
{
    public class HelloWorldController1 : Controller
    {
        [HttpGet("/HelloWorld/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/HelloWorld/Welcome/")]
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
