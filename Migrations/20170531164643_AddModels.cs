using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Vega.Data;
using Vega.Models;


namespace Vega.Migrations
{
    public partial class AddModels : Migration
    {
        private const string ConnectionStringLocalDB = "Server=(localdb)\\mssqllocaldb;Database=Vega;Trusted_Connection=True;MultipleActiveResultSets=true";

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var optionsBuilder = new DbContextOptionsBuilder<VegaDbContext>();
            optionsBuilder.UseSqlServer(ConnectionStringLocalDB);
            
            using (var db = new VegaDbContext(optionsBuilder.Options))
            {
                var makes = db.Makes.ToList();
                
                var honda = db.Makes.Where(x => x.Name == "Honda").Single();
                var yamaha = db.Makes.Where(x => x.Name == "Yamaha").Single();
                var kawasaki = db.Makes.Where(x => x.Name == "Kawasaki").Single();
                var suzuki = db.Makes.Where(x => x.Name == "Suzuki").Single();
                var ducati = db.Makes.Where(x => x.Name == "Ducati").Single();
                var bmw = db.Makes.Where(x => x.Name == "BMW").Single();
                var triumph = db.Makes.Where(x => x.Name == "Triumph").Single();

                var models = db.Models.ToList();
                
                var zx10rNinja = db.Models.Add(new Model() {
                    Name = "Ninja ZX-10R",
                    MakeId = kawasaki.Id,
                    Make = kawasaki,
                    Year = 2017,
                    EngineType = "Liquid-cooled, 4-stroke In-Line Four",
                    Displacement = 998,
                    BoreAndStroke = "76 x 55 mm",
                    CompressionRatio = "13.0:1",
                    MaxPower = "147.1 kW {200 PS} / 13,000 rpm",
                    MaxTorque = "113.5 N•m {11.6 kgf•m} / 11,500 rpm",
                    Lubrication = "Forced lubrication, wet sump with oil cooler",
                    Carburettor = "Fuel injection: Ø 47 mm x 4 with dual injection",
                    Starter = "Electric",
                    Transmission = "6-speed, cassette",
                    FinalDrive = "Sealed chain",
                    FuelConsumption = "5.9 l/100 km",
                    Frame = "Twin spar, cast aluminium",
                    FrontSuspension = "43 mm inverted fork with rebound and compression damping, spring preload adjustability and top-out springs",
                    RearSuspension = "Horizontal Back-link with gas-charged shock and top-out spring. Compression damping: Stepless, dual-range (high/low-speed). Rebound damping: Stepless. Spring preload: Fully adjustable",
                    FrontBrake = "Dual semi-floating 310 mm petal discs. Caliper: Dual radial-mount, opposed 4-(aluminium) piston",
                    RearBrake = "Single 220 mm petal disc. Caliper: Single-bore pin-slide, aluminium piston",
                    FrontTyre = "120/70ZR17M/C (58W)",
                    RearTyre = "190/55ZR17M/C (75W)",
                    Length = 2090,
                    Width = 740,
                    Height = 1145,
                    SeatHeight = 835,
                    WheelBase = 1440,
                    GroundClearance = 145,
                    FuelCapacity = 17,
                    WetWeight = 206
                });
                
                db.SaveChanges();
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var optionsBuilder = new DbContextOptionsBuilder<VegaDbContext>();
            optionsBuilder.UseSqlServer(ConnectionStringLocalDB);

            using (var db = new VegaDbContext(optionsBuilder.Options))
            {
                var zx10rNinja = db.Models.Where(m => m.Name == "Ninja ZX-10R").SingleOrDefault();
                if (zx10rNinja != null)
                {
                    db.Models.Remove(zx10rNinja);
                    db.SaveChanges();
                }
            }
        }

        private string GetConnectionString()
        {
            return ConnectionStringLocalDB;
        }
    }
}
