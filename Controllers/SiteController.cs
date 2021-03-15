using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewData_TempData_.Net_Core.Models;

namespace ViewData_TempData_.Net_Core.Controllers
{
    public class SiteController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "Shabi";
            TempData["City"] = "Karachi";
            //Person person = new Person();
            //person.FullName = "Shabahat Ali Chishti";
            //person.City = "Karachi";
            //ViewData["Person"] = person;

            //return View();
            //return RedirectToAction("Index2");
            return RedirectToAction("Index","Site2");
        }
        public IActionResult Index2()
        {
            return View();
        }
    }
}
