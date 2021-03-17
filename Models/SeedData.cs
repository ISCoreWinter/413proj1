using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace _413proj1.Models.ViewModels
{
    //this ensures that the DB is populated and loads any pending migrations.
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            TourTimesContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<TourTimesContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            //this if loop loads the seed data into the website if there isn't already any context.books data loaded
            if (!context.Tours.Any())
            {
                context.Tours.AddRange(
                    new TourTimes
                    {
                        Day = DayOfWeek.Sunday,
                        StartTime = "8:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Sunday,
                        StartTime = "9:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Sunday,
                        StartTime = "10:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Sunday,
                        StartTime = "11:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Sunday,
                        StartTime = "12:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Sunday,
                        StartTime = "1:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Sunday,
                        StartTime = "2:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Sunday,
                        StartTime = "3:00 pm",
                        Reserved = false
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Sunday,
                        StartTime = "4:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Sunday,
                        StartTime = "5:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Sunday,
                        StartTime = "6:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Sunday,
                        StartTime = "7:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Sunday,
                        StartTime = "8:00 pm",
                        Reserved = false,
                    },

                    new TourTimes
                    {
                        Day = DayOfWeek.Monday,
                        StartTime = "8:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Monday,
                        StartTime = "9:00 am",
                        Reserved = false
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Monday,
                        StartTime = "10:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Monday,
                        StartTime = "11:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Monday,
                        StartTime = "12:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Monday,
                        StartTime = "1:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Monday,
                        StartTime = "2:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Monday,
                        StartTime = "3:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Monday,
                        StartTime = "4:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Monday,
                        StartTime = "5:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Monday,
                        StartTime = "6:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Monday,
                        StartTime = "7:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Monday,
                        StartTime = "8:00 pm",
                        Reserved = false,
                    },

                    new TourTimes
                    {
                        Day = DayOfWeek.Tuesday,
                        StartTime = "8:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Tuesday,
                        StartTime = "9:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Tuesday,
                        StartTime = "10:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Tuesday,
                        StartTime = "11:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Tuesday,
                        StartTime = "12:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Tuesday,
                        StartTime = "1:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Tuesday,
                        StartTime = "2:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Tuesday,
                        StartTime = "3:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Tuesday,
                        StartTime = "4:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    { 
                        Day = DayOfWeek.Tuesday,
                        StartTime = "5:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Tuesday,
                        StartTime = "6:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Tuesday,
                        StartTime = "7:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Tuesday,
                        StartTime = "8:00 pm",
                        Reserved = false,
                    },

                     new TourTimes
                     {
                         Day = DayOfWeek.Wednesday,
                         StartTime = "8:00 am",
                         Reserved = false,
                     },
                    new TourTimes
                    {
                        Day = DayOfWeek.Wednesday,
                        StartTime = "9:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Wednesday,
                        StartTime = "10:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Wednesday,
                        StartTime = "11:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Wednesday,
                        StartTime = "12:00 pm",
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Wednesday,
                        StartTime = "1:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Wednesday,
                        StartTime = "2:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Wednesday,
                        StartTime = "3:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Wednesday,
                        StartTime = "4:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Wednesday,
                        StartTime = "5:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Wednesday,
                        StartTime = "6:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Wednesday,
                        StartTime = "7:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Wednesday,
                        StartTime = "8:00 pm",
                        Reserved = false,
                    },

                    new TourTimes
                    {
                        Day = DayOfWeek.Thursday,
                        StartTime = "8:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Thursday,
                        StartTime = "9:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Thursday,
                        StartTime = "10:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Thursday,
                        StartTime = "11:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Thursday,
                        StartTime = "12:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Thursday,
                        StartTime = "1:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Thursday,
                        StartTime = "2:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Thursday,
                        StartTime = "3:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Thursday,
                        StartTime = "4:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Thursday,
                        StartTime = "5:00 pm",
                        Reserved = false,
                    },

                    new TourTimes
                    {
                        Day = DayOfWeek.Thursday,
                        StartTime = "6:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Thursday,
                        StartTime = "7:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Thursday,
                        StartTime = "8:00 pm",
                        Reserved = false,
                    },

                    new TourTimes
                    {
                        Day = DayOfWeek.Friday,
                        StartTime = "8:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Friday,
                        StartTime = "9:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Friday,
                        StartTime = "10:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Friday,
                        StartTime = "11:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Friday,
                        StartTime = "12:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Friday,
                        StartTime = "1:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Friday,
                        StartTime = "2:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Friday,
                        StartTime = "3:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Friday,
                        StartTime = "4:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Friday,
                        StartTime = "5:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Friday,
                        StartTime = "6:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Friday,
                        StartTime = "7:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Friday,
                        StartTime = "8:00 pm",
                        Reserved = false,
                    },

                    new TourTimes
                    {
                        Day = DayOfWeek.Saturday,
                        StartTime = "8:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Saturday,
                        StartTime = "9:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Saturday,
                        StartTime = "10:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Saturday,
                        StartTime = "11:00 am",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Saturday,
                        StartTime = "12:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Saturday,
                        StartTime = "1:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Saturday,
                        StartTime = "2:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Saturday,
                        StartTime = "3:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Saturday,
                        StartTime = "4:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Saturday,
                        StartTime = "5:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Saturday,
                        StartTime = "6:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Saturday,
                        StartTime = "7:00 pm",
                        Reserved = false,
                    },
                    new TourTimes
                    {
                        Day = DayOfWeek.Saturday,
                        StartTime = "8:00 pm",
                        Reserved = false,
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}


