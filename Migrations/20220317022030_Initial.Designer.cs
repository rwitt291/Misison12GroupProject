﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Misison12GroupProject.Models;

namespace Misison12GroupProject.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220317022030_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Misison12GroupProject.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Taken")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("AppointmentID");

                    b.ToTable("appointments");

                    b.HasData(
                        new
                        {
                            AppointmentID = 1,
                            Taken = false,
                            Time = "8:00 AM"
                        },
                        new
                        {
                            AppointmentID = 2,
                            Taken = false,
                            Time = "9:00 AM"
                        },
                        new
                        {
                            AppointmentID = 3,
                            Taken = false,
                            Time = "10:00 AM"
                        },
                        new
                        {
                            AppointmentID = 4,
                            Taken = false,
                            Time = "11:00 AM"
                        },
                        new
                        {
                            AppointmentID = 5,
                            Taken = false,
                            Time = "12:00 PM"
                        },
                        new
                        {
                            AppointmentID = 6,
                            Taken = false,
                            Time = "1:00 PM"
                        },
                        new
                        {
                            AppointmentID = 7,
                            Taken = false,
                            Time = "2:00 PM"
                        },
                        new
                        {
                            AppointmentID = 8,
                            Taken = false,
                            Time = "3:00 PM"
                        },
                        new
                        {
                            AppointmentID = 9,
                            Taken = false,
                            Time = "4:00 PM"
                        },
                        new
                        {
                            AppointmentID = 10,
                            Taken = false,
                            Time = "5:00 PM"
                        },
                        new
                        {
                            AppointmentID = 11,
                            Taken = false,
                            Time = "6:00 PM"
                        },
                        new
                        {
                            AppointmentID = 12,
                            Taken = false,
                            Time = "7:00 PM"
                        },
                        new
                        {
                            AppointmentID = 13,
                            Taken = false,
                            Time = "8:00 PM"
                        },
                        new
                        {
                            AppointmentID = 14,
                            Taken = false,
                            Time = "8:00 AM"
                        },
                        new
                        {
                            AppointmentID = 15,
                            Taken = false,
                            Time = "9:00 AM"
                        },
                        new
                        {
                            AppointmentID = 16,
                            Taken = false,
                            Time = "10:00 AM"
                        },
                        new
                        {
                            AppointmentID = 17,
                            Taken = false,
                            Time = "11:00 AM"
                        },
                        new
                        {
                            AppointmentID = 18,
                            Taken = false,
                            Time = "12:00 PM"
                        },
                        new
                        {
                            AppointmentID = 19,
                            Taken = false,
                            Time = "1:00 PM"
                        },
                        new
                        {
                            AppointmentID = 20,
                            Taken = false,
                            Time = "2:00 PM"
                        },
                        new
                        {
                            AppointmentID = 21,
                            Taken = false,
                            Time = "3:00 PM"
                        },
                        new
                        {
                            AppointmentID = 22,
                            Taken = false,
                            Time = "4:00 PM"
                        },
                        new
                        {
                            AppointmentID = 23,
                            Taken = false,
                            Time = "5:00 PM"
                        },
                        new
                        {
                            AppointmentID = 24,
                            Taken = false,
                            Time = "6:00 PM"
                        },
                        new
                        {
                            AppointmentID = 25,
                            Taken = false,
                            Time = "7:00 PM"
                        },
                        new
                        {
                            AppointmentID = 26,
                            Taken = false,
                            Time = "8:00 PM"
                        },
                        new
                        {
                            AppointmentID = 27,
                            Taken = false,
                            Time = "8:00 AM"
                        },
                        new
                        {
                            AppointmentID = 28,
                            Taken = false,
                            Time = "9:00 AM"
                        },
                        new
                        {
                            AppointmentID = 29,
                            Taken = false,
                            Time = "10:00 AM"
                        },
                        new
                        {
                            AppointmentID = 30,
                            Taken = false,
                            Time = "11:00 AM"
                        },
                        new
                        {
                            AppointmentID = 31,
                            Taken = false,
                            Time = "12:00 PM"
                        },
                        new
                        {
                            AppointmentID = 32,
                            Taken = false,
                            Time = "1:00 PM"
                        },
                        new
                        {
                            AppointmentID = 33,
                            Taken = false,
                            Time = "2:00 PM"
                        },
                        new
                        {
                            AppointmentID = 34,
                            Taken = false,
                            Time = "3:00 PM"
                        },
                        new
                        {
                            AppointmentID = 35,
                            Taken = false,
                            Time = "4:00 PM"
                        },
                        new
                        {
                            AppointmentID = 36,
                            Taken = false,
                            Time = "5:00 PM"
                        },
                        new
                        {
                            AppointmentID = 37,
                            Taken = false,
                            Time = "6:00 PM"
                        },
                        new
                        {
                            AppointmentID = 38,
                            Taken = false,
                            Time = "7:00 PM"
                        },
                        new
                        {
                            AppointmentID = 39,
                            Taken = false,
                            Time = "8:00 PM"
                        },
                        new
                        {
                            AppointmentID = 40,
                            Taken = false,
                            Time = "8:00 AM"
                        },
                        new
                        {
                            AppointmentID = 41,
                            Taken = false,
                            Time = "9:00 AM"
                        },
                        new
                        {
                            AppointmentID = 42,
                            Taken = false,
                            Time = "10:00 AM"
                        },
                        new
                        {
                            AppointmentID = 43,
                            Taken = false,
                            Time = "11:00 AM"
                        },
                        new
                        {
                            AppointmentID = 44,
                            Taken = false,
                            Time = "12:00 PM"
                        },
                        new
                        {
                            AppointmentID = 45,
                            Taken = false,
                            Time = "1:00 PM"
                        },
                        new
                        {
                            AppointmentID = 46,
                            Taken = false,
                            Time = "2:00 PM"
                        },
                        new
                        {
                            AppointmentID = 47,
                            Taken = false,
                            Time = "3:00 PM"
                        },
                        new
                        {
                            AppointmentID = 48,
                            Taken = false,
                            Time = "4:00 PM"
                        },
                        new
                        {
                            AppointmentID = 49,
                            Taken = false,
                            Time = "5:00 PM"
                        },
                        new
                        {
                            AppointmentID = 50,
                            Taken = false,
                            Time = "6:00 PM"
                        },
                        new
                        {
                            AppointmentID = 51,
                            Taken = false,
                            Time = "7:00 PM"
                        },
                        new
                        {
                            AppointmentID = 52,
                            Taken = false,
                            Time = "8:00 PM"
                        },
                        new
                        {
                            AppointmentID = 53,
                            Taken = false,
                            Time = "8:00 AM"
                        },
                        new
                        {
                            AppointmentID = 54,
                            Taken = false,
                            Time = "9:00 AM"
                        },
                        new
                        {
                            AppointmentID = 55,
                            Taken = false,
                            Time = "10:00 AM"
                        },
                        new
                        {
                            AppointmentID = 56,
                            Taken = false,
                            Time = "11:00 AM"
                        },
                        new
                        {
                            AppointmentID = 57,
                            Taken = false,
                            Time = "12:00 PM"
                        },
                        new
                        {
                            AppointmentID = 58,
                            Taken = false,
                            Time = "1:00 PM"
                        },
                        new
                        {
                            AppointmentID = 59,
                            Taken = false,
                            Time = "2:00 PM"
                        },
                        new
                        {
                            AppointmentID = 60,
                            Taken = false,
                            Time = "3:00 PM"
                        },
                        new
                        {
                            AppointmentID = 61,
                            Taken = false,
                            Time = "4:00 PM"
                        },
                        new
                        {
                            AppointmentID = 62,
                            Taken = false,
                            Time = "5:00 PM"
                        },
                        new
                        {
                            AppointmentID = 63,
                            Taken = false,
                            Time = "6:00 PM"
                        },
                        new
                        {
                            AppointmentID = 64,
                            Taken = false,
                            Time = "7:00 PM"
                        },
                        new
                        {
                            AppointmentID = 65,
                            Taken = false,
                            Time = "8:00 PM"
                        },
                        new
                        {
                            AppointmentID = 66,
                            Taken = false,
                            Time = "8:00 AM"
                        },
                        new
                        {
                            AppointmentID = 67,
                            Taken = false,
                            Time = "9:00 AM"
                        },
                        new
                        {
                            AppointmentID = 68,
                            Taken = false,
                            Time = "10:00 AM"
                        },
                        new
                        {
                            AppointmentID = 69,
                            Taken = false,
                            Time = "11:00 AM"
                        },
                        new
                        {
                            AppointmentID = 70,
                            Taken = false,
                            Time = "12:00 PM"
                        },
                        new
                        {
                            AppointmentID = 71,
                            Taken = false,
                            Time = "1:00 PM"
                        },
                        new
                        {
                            AppointmentID = 72,
                            Taken = false,
                            Time = "2:00 PM"
                        },
                        new
                        {
                            AppointmentID = 73,
                            Taken = false,
                            Time = "3:00 PM"
                        },
                        new
                        {
                            AppointmentID = 74,
                            Taken = false,
                            Time = "4:00 PM"
                        },
                        new
                        {
                            AppointmentID = 75,
                            Taken = false,
                            Time = "5:00 PM"
                        },
                        new
                        {
                            AppointmentID = 76,
                            Taken = false,
                            Time = "6:00 PM"
                        },
                        new
                        {
                            AppointmentID = 77,
                            Taken = false,
                            Time = "7:00 PM"
                        },
                        new
                        {
                            AppointmentID = 78,
                            Taken = false,
                            Time = "8:00 PM"
                        },
                        new
                        {
                            AppointmentID = 79,
                            Taken = false,
                            Time = "8:00 AM"
                        },
                        new
                        {
                            AppointmentID = 80,
                            Taken = false,
                            Time = "9:00 AM"
                        },
                        new
                        {
                            AppointmentID = 81,
                            Taken = false,
                            Time = "10:00 AM"
                        },
                        new
                        {
                            AppointmentID = 82,
                            Taken = false,
                            Time = "11:00 AM"
                        },
                        new
                        {
                            AppointmentID = 83,
                            Taken = false,
                            Time = "12:00 PM"
                        },
                        new
                        {
                            AppointmentID = 84,
                            Taken = false,
                            Time = "1:00 PM"
                        },
                        new
                        {
                            AppointmentID = 85,
                            Taken = false,
                            Time = "2:00 PM"
                        },
                        new
                        {
                            AppointmentID = 86,
                            Taken = false,
                            Time = "3:00 PM"
                        },
                        new
                        {
                            AppointmentID = 87,
                            Taken = false,
                            Time = "4:00 PM"
                        },
                        new
                        {
                            AppointmentID = 88,
                            Taken = false,
                            Time = "5:00 PM"
                        },
                        new
                        {
                            AppointmentID = 89,
                            Taken = false,
                            Time = "6:00 PM"
                        },
                        new
                        {
                            AppointmentID = 90,
                            Taken = false,
                            Time = "7:00 PM"
                        },
                        new
                        {
                            AppointmentID = 91,
                            Taken = false,
                            Time = "8:00 PM"
                        });
                });

            modelBuilder.Entity("Misison12GroupProject.Models.GroupInfo", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppointmentID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GroupName")
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupSize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("phone")
                        .HasColumnType("TEXT");

                    b.HasKey("GroupId");

                    b.HasIndex("AppointmentID");

                    b.ToTable("group");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            AppointmentID = 1,
                            GroupName = "Group 10",
                            GroupSize = 4,
                            email = "dmitchellbuhler@gmail.com",
                            phone = "425-698-3436"
                        });
                });

            modelBuilder.Entity("Misison12GroupProject.Models.GroupInfo", b =>
                {
                    b.HasOne("Misison12GroupProject.Models.Appointment", "Appointment")
                        .WithMany()
                        .HasForeignKey("AppointmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
