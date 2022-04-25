﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SSquared.Infrastructure.Data;

#nullable disable

namespace SSquared.Infrastructure.Migrations
{
    [DbContext(typeof(SSquaredDbContext))]
    [Migration("20220422021012_InitialModel")]
    partial class InitialModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("EmployeeRole", b =>
                {
                    b.Property<int>("EmployeesEmployeeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RolesRoleID")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmployeesEmployeeID", "RolesRoleID");

                    b.HasIndex("RolesRoleID");

                    b.ToTable("EmployeeRole");
                });

            modelBuilder.Entity("SSquared.Core.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ManagerID")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmployeeID");

                    b.HasIndex("ManagerID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1,
                            FirstName = "Jeffrey",
                            LastName = "Wells"
                        },
                        new
                        {
                            EmployeeID = 2,
                            FirstName = "Victor",
                            LastName = "Atkins"
                        },
                        new
                        {
                            EmployeeID = 3,
                            FirstName = "Kelli",
                            LastName = "Hamilton"
                        },
                        new
                        {
                            EmployeeID = 4,
                            FirstName = "Adam",
                            LastName = "Braun"
                        },
                        new
                        {
                            EmployeeID = 5,
                            FirstName = "Lois",
                            LastName = "Martinez"
                        },
                        new
                        {
                            EmployeeID = 6,
                            FirstName = "Brian",
                            LastName = "Cruz"
                        },
                        new
                        {
                            EmployeeID = 7,
                            FirstName = "Michael",
                            LastName = "Lind"
                        },
                        new
                        {
                            EmployeeID = 8,
                            FirstName = "Kristen",
                            LastName = "Floyd"
                        },
                        new
                        {
                            EmployeeID = 9,
                            FirstName = "Eric",
                            LastName = "Bay"
                        },
                        new
                        {
                            EmployeeID = 10,
                            FirstName = "Brandon",
                            LastName = "Young"
                        });
                });

            modelBuilder.Entity("SSquared.Core.Models.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleID = 1,
                            Name = "Director"
                        },
                        new
                        {
                            RoleID = 3,
                            Name = "IT"
                        },
                        new
                        {
                            RoleID = 2,
                            Name = "Support"
                        },
                        new
                        {
                            RoleID = 4,
                            Name = "Accounting"
                        },
                        new
                        {
                            RoleID = 6,
                            Name = "Sales"
                        },
                        new
                        {
                            RoleID = 5,
                            Name = "Analyst"
                        });
                });

            modelBuilder.Entity("EmployeeRole", b =>
                {
                    b.HasOne("SSquared.Core.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesEmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SSquared.Core.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesRoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SSquared.Core.Models.Employee", b =>
                {
                    b.HasOne("SSquared.Core.Models.Employee", "Manager")
                        .WithMany("Reports")
                        .HasForeignKey("ManagerID");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("SSquared.Core.Models.Employee", b =>
                {
                    b.Navigation("Reports");
                });
#pragma warning restore 612, 618
        }
    }
}
