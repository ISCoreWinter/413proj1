﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _413proj1.Models;

namespace _413proj1.Migrations
{
    [DbContext(typeof(TourTimesContext))]
    partial class TourTimesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12");

            modelBuilder.Entity("_413proj1.Models.ReservationInformation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("TourId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ReservationId");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("_413proj1.Models.TourTimes", b =>
                {
                    b.Property<int>("TourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Day")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Reserved")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StartTime")
                        .HasColumnType("TEXT");

                    b.HasKey("TourId");

                    b.ToTable("Tours");
                });
#pragma warning restore 612, 618
        }
    }
}
