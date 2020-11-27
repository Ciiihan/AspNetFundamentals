using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCore3._1.Controllers
{
    public class HomeController : Controller
    {
        //public string Index ()
        //{
        //    return "İlk Görünüm";
        //}
        public IActionResult About ()
        {
            return View();
        }
    }
}
