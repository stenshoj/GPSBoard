﻿// <auto-generated />
using GPSBoard.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace GPSBoard.Data.Migrations
{
    [DbContext(typeof(GPSBoardContext))]
    [Migration("20171031134241_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GPSBoard.Common.Coordinate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Latitude");

                    b.Property<decimal>("Longitude");

                    b.HasKey("Id");

                    b.ToTable("Coordinates");
                });
#pragma warning restore 612, 618
        }
    }
}
