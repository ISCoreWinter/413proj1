using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _413proj1.Models
{
    public class ReservationInformation
    {
        [Key]
        [Required]
        public int ReservationId { get; set; }

        [Required]
        public string GroupName { get; set; }

        [Required]
        public string Email { get; set; }

        #nullable enable
        public string? PhoneNumber { get; set; }

        //add nullable for the time
    }
}