using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace _413proj1.Models
{
    public class TourTimes
    {
        [Key]
        public int TourId { get; set; }
        public DayOfWeek Day { get; set; }
        public string StartTime { get; set; }
        public bool Reserved { get; set; }
    }
}