﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ePraksa.Api.Models;

namespace ePraksa.Api.Migrations
{
    [DbContext(typeof(BaseContext))]
    [Migration("20201220211245_internship")]
    partial class internship
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ePraksa.Api.Models.Internship", b =>
                {
                    b.Property<int>("internshipID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("internshipDescription")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("internshipEndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("internshipName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("internshipStartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("mentorContactEmail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("mentorName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("internshipID");

                    b.ToTable("Internships");
                });

            modelBuilder.Entity("ePraksa.Api.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Course")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<int>("YearOfStudy")
                        .HasColumnType("int");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
