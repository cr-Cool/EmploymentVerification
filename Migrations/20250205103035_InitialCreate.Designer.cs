﻿// <auto-generated />
using EmploymentVerification.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmploymentVerification.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250205103035_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("EmploymentVerification.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CompanyName")
                        .HasColumnType("TEXT");

                    b.Property<string>("VerificationCode")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            CompanyName = "TechCorp",
                            VerificationCode = "ABC123"
                        },
                        new
                        {
                            Id = 102,
                            CompanyName = "InnovateX",
                            VerificationCode = "XYZ789"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
