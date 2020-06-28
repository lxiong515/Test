using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstResponsiveWebAppXiong1.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstResponsiveWebAppXiong1.Controllers
{
    public class HomeController : Controller
    {
        // Luke Xiong
        
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.BY = " ";
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(YearModel model)
        {
               ViewBag.BY = model.AgeThisYear();
               return View(model);
        }
    }
}
