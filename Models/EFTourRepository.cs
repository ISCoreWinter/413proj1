using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _413proj1.Models
{
    public class EFTourRepository : ITourRepository
    {
        private TourTimesContext _context;

        public EFTourRepository (TourTimesContext context)
        {
            _context = context;
        }

        public IQueryable<TourTimes> Tours => _context.Tours;
    }
}
