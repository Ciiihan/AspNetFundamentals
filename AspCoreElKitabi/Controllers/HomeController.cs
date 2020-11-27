using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreElKitabi.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult  Index()
        {
            return View(new string[] {"Bilgisayar","Monitor","Mouse","TouchPad","Sagopa" });
        }
        public IActionResult deneme()
        {
            return View();
        }
    }
}