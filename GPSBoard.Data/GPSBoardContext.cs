using GPSBoard.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GPSBoard.Data
{
    public class GPSBoardContext : DbContext 
    {
        public DbSet<Coordinate> Coordinates { get; set; }

        public GPSBoardContext(DbContextOptions<GPSBoardContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coordinate>().Property(c => c.Latitude).HasColumnType("decimal(18, 6)");
            modelBuilder.Entity<Coordinate>().Property(c => c.Longitude).HasColumnType("decimal(18, 6)");
        }
    }
}
