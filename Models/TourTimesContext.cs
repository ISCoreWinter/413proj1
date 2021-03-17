using _413proj1.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace _413proj1.Models
{
    public class TourTimesContext : DbContext
    {
        public TourTimesContext(DbContextOptions<TourTimesContext> options) : base(options)
        {

        }
        public DbSet<TourTimes> Tours { get; set; }
    }
}