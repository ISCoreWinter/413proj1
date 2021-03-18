using System;
using System.Collections.Generic;
using OnlineBookstore.Models.ViewModels;

namespace _413proj1.Models.ViewModels
{
    public class ViewAppts
    {
        public TourTimes Tours { get; set; }
        public IEnumerable<ReservationInformation> BookedReservations { get; set; }
    }
}
