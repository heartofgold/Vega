using System;
using Microsoft.EntityFrameworkCore;
using Vega.Models;

namespace Vega.Data
{
    public class VegaDbContext : DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }  
        public DbSet<Feature> Features { get; set; }
        public DbSet<ModelFeature> ModelFeatures { get; set; }
        
        public VegaDbContext(DbContextOptions<VegaDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Make>().HasKey(x => x.Id);
            modelBuilder.Entity<Make>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Make>().Property(x => x.Name).IsRequired().HasMaxLength(64);
            modelBuilder.Entity<Make>().Property(x => x.Country).IsRequired().HasMaxLength(64);

            modelBuilder.Entity<Model>().HasKey(x => x.Id);
            modelBuilder.Entity<Model>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Model>().Property(x => x.Name).IsRequired().HasMaxLength(64);
            modelBuilder.Entity<Model>().Property(x => x.MakeId).IsRequired();
            modelBuilder.Entity<Model>().Property(x => x.Year).IsRequired();
            modelBuilder.Entity<Model>().Property(x => x.ImageUrl).HasMaxLength(256);
            modelBuilder.Entity<Model>().Property(x => x.EngineType).IsRequired().HasMaxLength(128);
            modelBuilder.Entity<Model>().Property(x => x.Displacement).IsRequired();
            modelBuilder.Entity<Model>().Property(x => x.BoreAndStroke).HasMaxLength(32);
            modelBuilder.Entity<Model>().Property(x => x.CompressionRatio).HasMaxLength(16);
            modelBuilder.Entity<Model>().Property(x => x.MaxPower).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Model>().Property(x => x.MaxTorque).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Model>().Property(x => x.Lubrication).HasMaxLength(50);
            modelBuilder.Entity<Model>().Property(x => x.ClutchType).HasMaxLength(128);
            modelBuilder.Entity<Model>().Property(x => x.Carburettor).HasMaxLength(128);
            modelBuilder.Entity<Model>().Property(x => x.Ignition).HasMaxLength(32);
            modelBuilder.Entity<Model>().Property(x => x.Starter).IsRequired().HasMaxLength(16);
            modelBuilder.Entity<Model>().Property(x => x.Transmission).IsRequired().HasMaxLength(32);
            modelBuilder.Entity<Model>().Property(x => x.FinalDrive).IsRequired().HasMaxLength(32);
            modelBuilder.Entity<Model>().Property(x => x.FuelConsumption).HasMaxLength(32);
            modelBuilder.Entity<Model>().Property(x => x.Frame).HasMaxLength(128);
            modelBuilder.Entity<Model>().Property(x => x.FrontSuspension).HasMaxLength(128);
            modelBuilder.Entity<Model>().Property(x => x.RearSuspension).HasMaxLength(256);
            modelBuilder.Entity<Model>().Property(x => x.FrontBrake).HasMaxLength(128);
            modelBuilder.Entity<Model>().Property(x => x.RearBrake).HasMaxLength(128);
            modelBuilder.Entity<Model>().Property(x => x.FrontTyre).IsRequired().HasMaxLength(32);
            modelBuilder.Entity<Model>().Property(x => x.RearTyre).IsRequired().HasMaxLength(32);
            modelBuilder.Entity<Model>().Property(x => x.Length);
            modelBuilder.Entity<Model>().Property(x => x.Width);
            modelBuilder.Entity<Model>().Property(x => x.Height);
            modelBuilder.Entity<Model>().Property(x => x.SeatHeight);
            modelBuilder.Entity<Model>().Property(x => x.WheelBase);
            modelBuilder.Entity<Model>().Property(x => x.GroundClearance);
            modelBuilder.Entity<Model>().Property(x => x.FuelCapacity).IsRequired();
            modelBuilder.Entity<Model>().Property(x => x.WetWeight).IsRequired();
            modelBuilder.Entity<Model>().HasOne(x => x.Make).WithMany(x => x.Models).HasForeignKey(x => x.MakeId);

            modelBuilder.Entity<Feature>().HasKey(x => x.Id);
            modelBuilder.Entity<Feature>().Property(x => x.Name).IsRequired().HasMaxLength(128);
            modelBuilder.Entity<Feature>().Property(x => x.Description).HasMaxLength(1024);

            modelBuilder.Entity<ModelFeature>().HasKey(x => new { x.ModelId, x.FeatureId });
            modelBuilder.Entity<ModelFeature>().Property(x => x.ModelId).IsRequired();
            modelBuilder.Entity<ModelFeature>().Property(x => x.FeatureId).IsRequired();
            modelBuilder.Entity<ModelFeature>().HasOne(x => x.Model).WithMany(x => x.ModelFeatures).HasForeignKey(x => x.ModelId);
            modelBuilder.Entity<ModelFeature>().HasOne(x => x.Feature).WithMany(x => x.ModelFeatures).HasForeignKey(x => x.FeatureId);
        }
    }
}