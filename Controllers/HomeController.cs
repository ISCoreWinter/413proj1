using _413proj1.Models;
using _413proj1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineBookstore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _413proj1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ITourRepository _repository;
        public HomeController(ILogger<HomeController> logger, ITourRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewAppointments()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUpPage()
        {
            return View(new TourViewModel
            {
                Tours = _repository.Tours.OrderBy(t => ((int) t.Day)).ThenBy(t => t.StartTime).Where(t => !t.Reserved).ToList(),

                PagingInfo = new PagingInfo
                {
                    //these need to be changed later
                    CurrentPage = 1,
                    TotalNumItems = 1,
                    ItemsPerPage = 1,
                },

                CurrentCategory = ""

            });
        }

        [HttpPost]
        public IActionResult SignUpPage(int tourId)
        {
            if (ModelState.IsValid)
            {
                ReservationViewModel res = new ReservationViewModel
                {
                    tour = _repository.Tours.Where(t => t.TourId == tourId).SingleOrDefault()
                };

                return View("AddInfo", res);
            }

            return View();
        }

        [HttpGet]
        public IActionResult AddInfo()
        {
            return View();
        }

        
    }
}
