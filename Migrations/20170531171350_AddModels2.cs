using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Vega.Data;
using Vega.Models;

namespace Vega.Migrations
{
    public partial class AddModels2 : Migration
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
                
                var africaTwin = db.Models.Add(new Model() {
                    Name = "CRF1000L Africa Twin",
                    MakeId = honda.Id,
                    Make = honda,
                    Year = 2017,
                    EngineType = "998cc liquid-cooled 4-stroke Unicam 8-valve Parallel Twin with 270º crank",
                    Displacement = 998,
                    BoreAndStroke = "92mm x 75mm",
                    CompressionRatio = "10:1",
                    MaxPower = "70kW/7,500rpm (95/1/EC)",
                    MaxTorque = "98Nm/6,000rpm (95/1/EC)",
                    Lubrication = "Forced lubrication, wet sump with oil cooler",
                    ClutchType = "Wet, multi-plate with coil springs, aluminum cam assist and slipper clutch",
                    Starter = "Electric",
                    Transmission = "Constant mesh 6-speed MT",
                    FinalDrive = "O-ring sealed chain",
                    FuelConsumption = "21.7 km/l (WMTC)",
                    Frame = "Steel semi-double cradle type with high-tensile strength steel rear sub-frame",
                    FrontSuspension = "Show 45mm cartridge-type inverted telescopic fork with dial-style preload adjuster and DF adjustment, 230mm stroke",
                    RearSuspension = "Monoblock cast aluminium swing arm with Pro-Link with gas-charged damper, hydraulic dial-style preload adjuster and rebound damping adjustment, 220 mm rear wheel travel",
                    FrontBrake = "310mm dual wave floating hydraulic disc with aluminum hub and radial fit 4-piston calipers and sintered metal pads",
                    RearBrake = "256mm wave hydraulic disc with 2-piston caliper and sintered metal pads",
                    FrontTyre = "90/90-R21 tube type",
                    RearTyre = "150/70-R18 tube type",
                    Length = 2335,
                    Width = 930,
                    Height = 1475,
                    SeatHeight = 850,
                    WheelBase = 1440,
                    GroundClearance = 250,
                    FuelCapacity = 18.8,
                    WetWeight = 232
                });
                
                var crf250Rally = db.Models.Add(new Model() {
                    Name = "CRF250 Rally",
                    MakeId = honda.Id,
                    Make = honda,
                    Year = 2017,
                    EngineType = "Liquid-cooled, Single, DOHC",
                    Displacement = 250,
                    BoreAndStroke = "76.0 x 55.0",
                    CompressionRatio = "10.7:1",
                    MaxPower = "18.2kW/8500rpm",
                    MaxTorque = "22.6Nm/6750rpm",
                    ClutchType = "Wet multiplate hydraulic",
                    Carburettor = "PGM-FI",
                    Starter = "Electric",
                    Transmission = "6-speed",
                    FinalDrive = "Chain",
                    FuelConsumption = "33.3km/litre",
                    Frame = "Steel Twin Tube",
                    FrontSuspension = "43mm Telescopic Upsidedown",
                    RearSuspension = "Prolink",
                    FrontTyre = "3.00-21 51P",
                    RearTyre = "120/80-18M/C 62P",
                    Length = 2210,
                    Width = 900,
                    Height = 1425,
                    SeatHeight = 895,
                    WheelBase = 1455,
                    GroundClearance = 270,
                    FuelCapacity = 10.1,
                    WetWeight = 157
                });
                
                var r1200rSport =  db.Models.Add(new Model() {
                    Name = "R 1200 R Sport",
                    MakeId = bmw.Id,
                    Make = bmw,
                    Year = 2017,
                    EngineType = "Air/oil-cooled, Boxer twin",
                    Displacement = 1170,
                    BoreAndStroke = "101.0 x 73.0 mm",
                    CompressionRatio = "12.5:1",
                    MaxPower = "125 bhp at 7,750 rpm",
                    MaxTorque = "125 Nm at 6,500 rpm",
                    Lubrication = "Dry sump",
                    ClutchType = "Wet eight-disc clutch with anti-hopping function, hydraulically operated",
                    Carburettor = "Injection. Digital engine management with electronic fuel injection, electronic throttle valve control (fly by wire)",
                    Starter = "Electric",
                    Transmission = "6-speed",
                    FinalDrive = "Shaft drive (cardan)",
                    Frame = "Two-section frame, front- and bolted on rear frame, load-bearing engine",
                    FrontSuspension = "Upside-down telescopic fork. diameter 45 mm, silver-anodized",
                    RearSuspension = "BMW Motorrad EVO Paralever",
                    FrontBrake = "Double disc. ABS. Four-piston calipers",
                    RearBrake = "Single disc. ABS. Floating disc. Two-piston calipers.",
                    FrontTyre = "120/70-ZR17",
                    RearTyre = "180/55-ZR17",
                    Length = 2165,
                    Width = 880,
                    Height = 1300,
                    SeatHeight = 790,
                    WheelBase = 1515,
                    GroundClearance = 270,
                    FuelCapacity = 18,
                    WetWeight = 232
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
                var africaTwin = db.Models.Where(m => m.Name == "CRF1000L Africa Twin").SingleOrDefault();
                if (africaTwin != null)
                {
                    db.Models.Remove(africaTwin);              
                }

                var crf250Rally = db.Models.Where(m => m.Name == "CRF250 Rally").SingleOrDefault();
                if (crf250Rally != null)
                {
                    db.Models.Remove(crf250Rally);              
                }

                var r1200RSport = db.Models.Where(m => m.Name == "R 1200 R Sport").SingleOrDefault();
                if (r1200RSport != null)
                {
                    db.Models.Remove(r1200RSport);              
                }
       
                db.SaveChanges();
            }
        }

        private string GetConnectionString()
        {
            return ConnectionStringLocalDB;
        }
    }
}
