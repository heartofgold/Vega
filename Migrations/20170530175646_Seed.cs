using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Vega.Data;
using Vega.Models;

namespace Vega.Migrations
{
    public partial class Seed : Migration
    {
        private const string ConnectionStringLocalDB = "Server=(localdb)\\mssqllocaldb;Database=Vega;Trusted_Connection=True;MultipleActiveResultSets=true";

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var optionsBuilder = new DbContextOptionsBuilder<VegaDbContext>();
            optionsBuilder.UseSqlServer(ConnectionStringLocalDB);

            using (var db = new VegaDbContext(optionsBuilder.Options))
            {
                var makes = db.Makes.ToList();
                if (!makes.Any())
                {
                    db.Makes.Add(new Make() { Name = "Honda", Country = "Japan" });
                    db.Makes.Add(new Make() { Name = "Kawasaki", Country = "Japan" });
                    db.Makes.Add(new Make() { Name = "Yamaha", Country = "Japan" });
                    db.Makes.Add(new Make() { Name = "Suzuki", Country = "Japan" });
                    db.Makes.Add(new Make() { Name = "KTM", Country = "Austria" });
                    db.Makes.Add(new Make() { Name = "Ducati", Country = "Italy" });
                    db.Makes.Add(new Make() { Name = "BMW", Country = "Germany" });
                    db.Makes.Add(new Make() { Name = "Triumph", Country = "United Kingdom" });
                    db.Makes.Add(new Make() { Name = "Harley Davidson", Country = "USA" });
                    db.Makes.Add(new Make() { Name = "Aprilia", Country = "Italy"  });

                    db.SaveChanges();
                }

                 var honda = db.Makes.Where(x => x.Name == "Honda").Single();
                 var yamaha = db.Makes.Where(x => x.Name == "Yamaha").Single();
                 var kawasaki = db.Makes.Where(x => x.Name == "Kawasaki").Single();
                 var suzuki = db.Makes.Where(x => x.Name == "Suzuki").Single();
                 var ducati = db.Makes.Where(x => x.Name == "Ducati").Single();
                 var bmw = db.Makes.Where(x => x.Name == "BMW").Single();
                 var triumph = db.Makes.Where(x => x.Name == "Triumph").Single();

                 var models = db.Models.ToList();
                 if (!models.Any())
                 {
                     var mt10Sp = db.Models.Add(new Model() {
                         Name = "MT10SP",
                         MakeId = yamaha.Id,
                         Make = yamaha,
                         Year = 2017,
                         EngineType = "liquid-cooled, 4-stroke, DOHC, 4-valves",
                         Displacement = 998,
                         BoreAndStroke = "79.0 mm x 50.9 mm",
                         CompressionRatio = "12 : 1",
                         MaxPower = "118.0 kW (160.4PS) @ 11,500 rpm",
                         MaxTorque = "111.0 Nm (11.3 kg-m) @ 9,000 rpm",
                         Lubrication = "Wet sump",
                         ClutchType = "Wet, Multiple Disc",
                         Carburettor = "Fuel Injection",
                         Ignition = "TCI",
                         Starter = "Electric",
                         Transmission = "Constant Mesh, 6-speed",
                         FinalDrive = "Chain",
                         FuelConsumption = "8.0 l/100km",
                         Frame = "Aluminium Deltabox",
                         FrontSuspension = "Telescopic forks, Ø 43 mm",
                         RearSuspension = "Swingarm, (link suspension)",
                         FrontBrake = "Hydraulic dual disc, Ø 320 mm",
                         RearBrake = "Hydraulic single disc, Ø 220 mm",
                         FrontTyre = "20/70 ZR17 M/C (58W)",
                         RearTyre = "190/55 ZR17 M/C (75W)",
                         Length = 2095,
                         Width = 800,
                         Height = 1110,
                         SeatHeight = 825,
                         WheelBase = 1400,
                         GroundClearance = 130,
                         FuelCapacity = 17,
                         WetWeight = 210
                     });

                     var scr950 = db.Models.Add(new Model() {
                         Name = "SCR950",
                         MakeId = yamaha.Id,
                         Make = yamaha,
                         Year = 2017,
                         EngineType = "4-stroke, air-cooled, 4-valves, SOHC, V-type 2-cylinder",
                         Displacement = 942,
                         BoreAndStroke = "85.0 mm x 83.0 mm",
                         CompressionRatio = "9.0 : 1",
                         MaxPower = "40 kW (54.3PS) @ 5,500 rpm",
                         MaxTorque = "79.5 Nm (8.1 kg-m) @ 3,000 rpm",
                         Lubrication = "Wet sump",
                         ClutchType = "Wet, Multiple Disc",
                         Carburettor = "Fuel Injection",
                         Ignition = "TCI",
                         Starter = "Electric",
                         Transmission = "Constant Mesh, 5-speed",
                         FinalDrive = "Belt",
                         FuelConsumption = "5.0 l/100km",
                         Frame = "double cradle",
                         FrontSuspension = "Telescopic forks, Ø 41 mm",
                         RearSuspension = "Swingarm",
                         FrontBrake = "Hydraulic single disc, Ø 298 mm",
                         RearBrake = "Hydraulic single disc, Ø 298 mm",
                         FrontTyre = "100/90-19M/C 57H",
                         RearTyre = "140/80R17M/C 69H",
                         Length = 2255,
                         Width = 895,
                         Height = 1170,
                         SeatHeight = 830,
                         WheelBase = 1575,
                         GroundClearance = 145,
                         FuelCapacity = 13,
                         WetWeight = 252
                     });
                     
                     var streetScrambler = db.Models.Add(new Model() {
                         Name = "Street Scrambler",
                         MakeId = triumph.Id,
                         Make = triumph,
                         Year = 2017,
                         EngineType = "Liquid cooled, 8 valve, SOHC, 270° crank angle parallel twin",
                         Displacement = 900,
                         BoreAndStroke = "84.6 mm x 80 mm",
                         CompressionRatio = "10.55: 1",
                         MaxPower = "55 PS / 54 BHP (40.5kW) @ 6000 rpm",
                         MaxTorque = "80Nm @ 2850 rpm",
                         Carburettor = "Fuel Injection",
                         Starter = "Electric",
                         Transmission = "5-speed",
                         FinalDrive = "Chain",
                         FrontBrake = "Single 310mm solid disc, 2-piston Nissin floating caliper, ABS",
                         RearBrake = "Single 255mm disc, Nissin 2-piston floating caliper, ABS",
                         FrontTyre = "100/90-19 Metzler Tourance",
                         RearTyre = "150/70 R17 Metzler Tourance",
                         Length = 2178,
                         Width = 831,
                         Height = 1120,
                         SeatHeight = 792,
                         WheelBase = 1446,
                         GroundClearance = 145,
                         FuelCapacity = 12,
                         WetWeight = 213
                     });

                     db.SaveChanges();
                 }
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var optionsBuilder = new DbContextOptionsBuilder<VegaDbContext>();
            optionsBuilder.UseSqlServer(ConnectionStringLocalDB);

            using (var db = new VegaDbContext(optionsBuilder.Options))
            {
                var makes = db.Makes.ToList();
                if (makes.Any())
                {
                    db.Makes.RemoveRange(makes);
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
