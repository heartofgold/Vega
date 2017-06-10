using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Vega.Data;

namespace Vega.Migrations
{
    [DbContext(typeof(VegaDbContext))]
    [Migration("20170531164532_UpdateModels2")]
    partial class UpdateModels2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Vega.Models.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Feature");
                });

            modelBuilder.Entity("Vega.Models.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Makes");
                });

            modelBuilder.Entity("Vega.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BoreAndStroke")
                        .HasMaxLength(32);

                    b.Property<string>("Carburettor")
                        .HasMaxLength(128);

                    b.Property<string>("ClutchType")
                        .HasMaxLength(128);

                    b.Property<string>("CompressionRatio")
                        .HasMaxLength(16);

                    b.Property<int>("Displacement");

                    b.Property<string>("EngineType")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("FinalDrive")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("Frame")
                        .HasMaxLength(128);

                    b.Property<string>("FrontBrake")
                        .HasMaxLength(128);

                    b.Property<string>("FrontSuspension")
                        .HasMaxLength(128);

                    b.Property<string>("FrontTyre")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<double?>("FuelCapacity")
                        .IsRequired();

                    b.Property<string>("FuelConsumption")
                        .HasMaxLength(32);

                    b.Property<double?>("GroundClearance");

                    b.Property<double?>("Height");

                    b.Property<string>("Ignition")
                        .HasMaxLength(32);

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(256);

                    b.Property<double?>("Length");

                    b.Property<string>("Lubrication")
                        .HasMaxLength(50);

                    b.Property<int>("MakeId");

                    b.Property<string>("MaxPower")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("MaxTorque")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("RearBrake")
                        .HasMaxLength(128);

                    b.Property<string>("RearSuspension")
                        .HasMaxLength(256);

                    b.Property<string>("RearTyre")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<double?>("SeatHeight");

                    b.Property<string>("Starter")
                        .IsRequired()
                        .HasMaxLength(16);

                    b.Property<string>("Transmission")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<double?>("WetWeight")
                        .IsRequired();

                    b.Property<double?>("WheelBase");

                    b.Property<double?>("Width");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("MakeId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("Vega.Models.ModelFeature", b =>
                {
                    b.Property<int>("ModelId");

                    b.Property<int>("FeatureId");

                    b.HasKey("ModelId", "FeatureId");

                    b.HasIndex("FeatureId");

                    b.ToTable("ModelFeature");
                });

            modelBuilder.Entity("Vega.Models.Model", b =>
                {
                    b.HasOne("Vega.Models.Make", "Make")
                        .WithMany("Models")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Vega.Models.ModelFeature", b =>
                {
                    b.HasOne("Vega.Models.Feature", "Feature")
                        .WithMany("ModelFeatures")
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Vega.Models.Model", "Model")
                        .WithMany("ModelFeatures")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
