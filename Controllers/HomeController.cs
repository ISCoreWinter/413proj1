using _413proj1.Models;
using _413proj1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private TourTimesContext _context { get; set; }
        public HomeController(ILogger<HomeController> logger, ITourRepository repository, TourTimesContext con)
        {
            _logger = logger;
            _repository = repository;
            _context = con;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewAppointments()
        {

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
        public IActionResult AddInfo(int tourId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddInfo(ReservationViewModel res, int tourId)
        {
            if (ModelState.IsValid)
            {
                res.reservation.TourId = tourId;

                res.tour = _context.Tours.Where(t => t.TourId == tourId).SingleOrDefault();

                _context.Reservation.Add(res.reservation);

                TourTimes result = _context.Tours.SingleOrDefault(t => t.TourId == res.tour.TourId);
                if (result != null)
                {
                    result.Reserved = true;
                }

                _context.SaveChanges();
            }
            return View("Index");
        }

    }
}
