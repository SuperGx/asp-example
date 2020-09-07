using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exx1.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Exx1.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            //
            ViewBag.title = "Contact us ";
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return View();
            }
        }
        public IActionResult About()
        {
            ViewBag.title = "About us";
            return View();
        }
    }
}
