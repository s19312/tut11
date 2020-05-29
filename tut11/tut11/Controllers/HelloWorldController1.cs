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
            return Ok("This is a defaul action...");
        }

        [HttpGet("/HelloWorld/Welcome/")]
        public IActionResult Welcome(string name, int ID = 1)
        {
            return Ok(HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}"));
        }
    }
}
