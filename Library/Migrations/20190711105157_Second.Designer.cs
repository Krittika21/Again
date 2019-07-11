﻿// <auto-generated />
using System;
using Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Library.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20190711105157_Second")]
    partial class Second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Library.Models.AthletesDetails", b =>
                {
                    b.Property<int>("AthleteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CTDistance");

                    b.Property<string>("FitnessRating");

                    b.Property<string>("Name");

                    b.Property<DateTime>("STTime");

                    b.Property<int?>("TestDetailsID");

                    b.HasKey("AthleteId");

                    b.HasIndex("TestDetailsID");

                    b.ToTable("AthletesDetails");
                });

            modelBuilder.Entity("Library.Models.TestDetails", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NoOfParticipants");

                    b.Property<DateTime>("TestDate");

                    b.Property<int?>("TestTypeID");

                    b.HasKey("ID");

                    b.HasIndex("TestTypeID");

                    b.ToTable("TestDetails");
                });

            modelBuilder.Entity("Library.Models.TestType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("TestType");
                });

            modelBuilder.Entity("Library.Models.AthletesDetails", b =>
                {
                    b.HasOne("Library.Models.TestDetails")
                        .WithMany("Athletes")
                        .HasForeignKey("TestDetailsID");
                });

            modelBuilder.Entity("Library.Models.TestDetails", b =>
                {
                    b.HasOne("Library.Models.TestType", "TestType")
                        .WithMany()
                        .HasForeignKey("TestTypeID");
                });
#pragma warning restore 612, 618
        }
    }
}
