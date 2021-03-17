﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _413proj1.Models;

namespace _413proj1.Migrations
{
    [DbContext(typeof(TourTimesContext))]
    [Migration("20210317073013_mig2")]
    partial class mig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12");

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
