using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fun.Areas.Stores.Controllers
{
    public class Stores : Controller
    {

        public static void initialize(IServiceProvider serviceProvider)
        {

        }



        public IActionResult Index()
        {
            return View();
        }
    }
}
