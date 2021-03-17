using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _413proj1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewAppointments()
        {
            return View();
        }

        public IActionResult SignUpPage()
        {
            return View();
        }
    }
}
