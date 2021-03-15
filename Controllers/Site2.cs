using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewData_TempData_.Net_Core.Controllers
{
    public class Site2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
