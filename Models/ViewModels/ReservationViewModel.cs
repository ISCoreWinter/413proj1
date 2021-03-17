using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _413proj1.Models.ViewModels
{
    public class ReservationViewModel
    {
        public ReservationInformation reservation { get; set; }
        public TourTimes tour { get; set; }
    }
}
