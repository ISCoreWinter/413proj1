using System;
using System.Collections.Generic;
using OnlineBookstore.Models.ViewModels;

namespace _413proj1.Models.ViewModels
{
    public class TourViewModel
    {
        public IEnumerable<TourTimes> Tours { get; set; }
        //public PagingInfo PagingInfo { get; set; }
        //public string CurrentCategory { get; set; }
    }
}