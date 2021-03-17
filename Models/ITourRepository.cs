using System;
using System.Collections.Generic;
using System.Linq;
using _413proj1.Models.ViewModels;

namespace _413proj1.Models
{
    public interface ITourRepository
    {
        IQueryable<TourTimes> Tours { get; }
    }
}
