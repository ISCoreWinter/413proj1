using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _413proj1.Models
{
    public class ReservationInformationContext : DbContext
    {
        public ReservationInformationContext(DbContextOptions<ReservationInformationContext> options) : base(options)
        {

        }
        public DbSet<ReservationInformation> Reservations { get; set; }
    }
}