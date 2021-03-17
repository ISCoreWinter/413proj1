using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _413proj1.Models;
using _413proj1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
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