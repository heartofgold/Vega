using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Vega.Data;
using Vega.Models;

namespace Vega.Migrations
{
    public partial class AddFeatures : Migration
    {
        private const string ConnectionStringLocalDB = "Server=(localdb)\\mssqllocaldb;Database=Vega;Trusted_Connection=True;MultipleActiveResultSets=true";
        
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var optionsBuilder = new DbContextOptionsBuilder<VegaDbContext>();
            optionsBuilder.UseSqlServer(ConnectionStringLocalDB);
            
            using (var db = new VegaDbContext(optionsBuilder.Options))
            {
                var models = db.Models.ToList();
                
                var mt10Sp = models.Where(m => m.Name == "MT10SP").Single();
                var scr950 = models.Where(m => m.Name == "SCR950").Single();
                var streetScrambler = models.Where(m => m.Name == "Street Scrambler").Single();
                var zx10rNinja = models.Where(m => m.Name == "Ninja ZX-10R").Single();
                var africaTwin = models.Where(m => m.Name == "CRF1000L Africa Twin").Single();
                var crf250Rally = models.Where(m => m.Name == "CRF250 Rally").Single();
                var r1200rSport = models.Where(m => m.Name == "R 1200 R Sport").Single();

                var crossplaneEngine = db.Features.Add(new Feature() 
                { 
                    Name = "Latest Generation Crossplane Crankshaft Engine", 
                    Description = "The potent 998cc inline 4-cylinder engine features the same Crossplane Crankshaft technology "
                        + "developed in Yamaha’s renowned YZF-R1 superbike. Tuned specifically for the FZ-10™, this engine "
                        + "develops awesome low- and mid-rpm torque with arm-stretching top-end power." 
                });
                var ycct = db.Features.Add(new Feature() 
                { 
                    Name = "Yamaha Chip Controlled Throttle with D-MODE and Cruise Control", 
                    Description = "The FZ-10 features YCC-T®—a ride-by-wire throttle system that provides exceptionally precise "
                        + "engine control—and D-MODE, which allows the rider to select a preferred engine response at the flick of "
                        + "a switch. The FZ-10 also includes cruise control for improved highway cruising comfort." 
                });
                var tractionControl = db.Features.Add(new Feature()
                {
                    Name = "Traction Control System",
                    Description = "An advanced Traction Control System (TCS) assists the rider in managing traction on various road "
                        + "conditions by quickly modulating throttle opening, ignition timing, fuel volume and other parameters."
                });
                var deltaboxFrame = db.Features.Add(new Feature() 
                {
                    Name = "Deltabox® Aluminum Frame",
                    Description = "Like the YZF-R1® superbike, the FZ-10 uses an aluminum Deltabox frame to create a lightweight "
                        + "and responsive chassis built for agility, featuring an ultra-compact 55.1-inch wheelbase." 
                });
                var kybSuspension = db.Features.Add(new Feature() 
                {
                    Name = "Fully-Adjustable KYB® Suspension",
                    Description = "The FZ-10 features a fully-adjustable inverted KYB® front fork and a four-way-adjustable, "
                        + "linkage-type KYB® shock, for excellent road holding along with a tuning range ready for a wide range of "
                        + "street conditions."
                });
                var abs = db.Features.Add(new Feature() 
                {
                    Name = "Powerful, Controllable Brakes with ABS",
                    Description = "An advanced Anti-lock Braking System (ABS) is mated to high-specification braking components "
                        + "for strong braking power with excellent feedback and control."
                });
                var agressiveEgonomics = db.Features.Add(new Feature() 
                {
                    Name = "Aggressive Ergonomics and Styling",
                    Description = "The FZ-10 displays raw aggression from every angle, with upright ergonomics that perfectly balance "
                        + "sport riding feedback and relaxed comfort. High-tech LED lighting and an all-LCD instrument panel boost both "
                        + "style and function."
                });
                var inclineDetection = db.Features.Add(new Feature() 
                {
                    Name = "Incline Detection",
                    Description = "While you're riding uphill, upshifts are delayed to keep rpm in the thicker part of the powerband."
                });
                var sixSpeed = db.Features.Add(new Feature() 
                {
                    Name = "6-speed manual gearbox",
                    Description = ""
                });
                var dct = db.Features.Add(new Feature() 
                {
                    Name = "Dual-Clutch Transmission",
                    Description = "Optional dual-clutch transmission that allows for fully automatic shifting."
                });
                var offRoad = db.Features.Add(new Feature() 
                {
                    Name = "Off-road ability",
                    Description = ""
                });
                var titaniumValves = db.Features.Add(new Feature() 
                {
                    Name = "Titanium intake valves",
                    Description = ""
                });
                var quickshifter = db.Features.Add(new Feature() 
                {
                    Name = "Quickshifter",
                    Description = ""
                });
                var boschImu = db.Features.Add(new Feature() 
                {
                    Name = "Bosch 5-axis IMU",
                    Description = ""
                });
                var klcm = db.Features.Add(new Feature() 
                {
                    Name = "Kawasaki Launch Control Mode",
                    Description = ""
                });
                var brakeLight = db.Features.Add(new Feature() 
                {
                    Name = "Dynamic Brake Light",
                    Description = ""
                });
                var shaftDrive = db.Features.Add(new Feature() 
                {
                    Name = "Shaft drive",
                    Description = ""
                });
                var spokedWheels = db.Features.Add(new Feature() 
                {
                    Name = "Spoked Wheels",
                    Description = ""
                });
                var stabilityControl = db.Features.Add(new Feature() 
                {
                    Name = "Automatic Stability Control",
                    Description = ""
                });
                var leds = db.Features.Add(new Feature() 
                {
                    Name = "LED Indicators",
                    Description = ""
                });

                db.SaveChanges();

                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = crossplaneEngine.Entity,
                    FeatureId = crossplaneEngine.Entity.Id,
                    Model = mt10Sp,
                    ModelId = mt10Sp.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = ycct.Entity,
                    FeatureId = ycct.Entity.Id,
                    Model = mt10Sp,
                    ModelId = mt10Sp.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = tractionControl.Entity,
                    FeatureId = tractionControl.Entity.Id,
                    Model = mt10Sp,
                    ModelId = mt10Sp.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = tractionControl.Entity,
                    FeatureId = tractionControl.Entity.Id,
                    Model = zx10rNinja,
                    ModelId = zx10rNinja.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = tractionControl.Entity,
                    FeatureId = tractionControl.Entity.Id,
                    Model = r1200rSport,
                    ModelId = r1200rSport.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = tractionControl.Entity,
                    FeatureId = tractionControl.Entity.Id,
                    Model = africaTwin,
                    ModelId = africaTwin.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = deltaboxFrame.Entity,
                    FeatureId = deltaboxFrame.Entity.Id,
                    Model = mt10Sp,
                    ModelId = mt10Sp.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = kybSuspension.Entity,
                    FeatureId = kybSuspension.Entity.Id,
                    Model = mt10Sp,
                    ModelId = mt10Sp.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = kybSuspension.Entity,
                    FeatureId = kybSuspension.Entity.Id,
                    Model = streetScrambler,
                    ModelId = streetScrambler.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = abs.Entity,
                    FeatureId = abs.Entity.Id,
                    Model = mt10Sp,
                    ModelId = mt10Sp.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = abs.Entity,
                    FeatureId = abs.Entity.Id,
                    Model = streetScrambler,
                    ModelId = streetScrambler.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = abs.Entity,
                    FeatureId = abs.Entity.Id,
                    Model = zx10rNinja,
                    ModelId = zx10rNinja.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = abs.Entity,
                    FeatureId = abs.Entity.Id,
                    Model = africaTwin,
                    ModelId = africaTwin.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = abs.Entity,
                    FeatureId = abs.Entity.Id,
                    Model = crf250Rally,
                    ModelId = crf250Rally.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = abs.Entity,
                    FeatureId = abs.Entity.Id,
                    Model = r1200rSport,
                    ModelId = r1200rSport.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = agressiveEgonomics.Entity,
                    FeatureId = agressiveEgonomics.Entity.Id,
                    Model = mt10Sp,
                    ModelId = mt10Sp.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = inclineDetection.Entity,
                    FeatureId = inclineDetection.Entity.Id,
                    Model = africaTwin,
                    ModelId = africaTwin.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = sixSpeed.Entity,
                    FeatureId = sixSpeed.Entity.Id,
                    Model = mt10Sp,
                    ModelId = mt10Sp.Id                    
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = sixSpeed.Entity,
                    FeatureId = sixSpeed.Entity.Id,
                    Model = zx10rNinja,
                    ModelId = zx10rNinja.Id    
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = sixSpeed.Entity,
                    FeatureId = sixSpeed.Entity.Id,
                    Model = africaTwin,
                    ModelId = africaTwin.Id  
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = sixSpeed.Entity,
                    FeatureId = sixSpeed.Entity.Id,
                    Model = r1200rSport,
                    ModelId = r1200rSport.Id    
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = dct.Entity,
                    FeatureId = dct.Entity.Id,
                    Model = africaTwin,
                    ModelId = africaTwin.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = offRoad.Entity,
                    FeatureId = offRoad.Entity.Id,
                    Model = africaTwin,
                    ModelId = africaTwin.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = offRoad.Entity,
                    FeatureId = offRoad.Entity.Id,
                    Model = streetScrambler,
                    ModelId = streetScrambler.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = offRoad.Entity,
                    FeatureId = offRoad.Entity.Id,
                    Model = crf250Rally,
                    ModelId = crf250Rally.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = titaniumValves.Entity,
                    FeatureId = titaniumValves.Entity.Id,
                    Model = zx10rNinja,
                    ModelId = zx10rNinja.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = quickshifter.Entity,
                    FeatureId = quickshifter.Entity.Id,
                    Model = mt10Sp,
                    ModelId = mt10Sp.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = quickshifter.Entity,
                    FeatureId = quickshifter.Entity.Id,
                    Model = zx10rNinja,
                    ModelId = zx10rNinja.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = quickshifter.Entity,
                    FeatureId = quickshifter.Entity.Id,
                    Model = r1200rSport,
                    ModelId = r1200rSport.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = boschImu.Entity,
                    FeatureId = boschImu.Entity.Id,
                    Model = zx10rNinja,
                    ModelId = zx10rNinja.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = klcm.Entity,
                    FeatureId = klcm.Entity.Id,
                    Model = zx10rNinja,
                    ModelId = zx10rNinja.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = brakeLight.Entity,
                    FeatureId = brakeLight.Entity.Id,
                    Model = r1200rSport,
                    ModelId = r1200rSport.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = shaftDrive.Entity,
                    FeatureId = shaftDrive.Entity.Id,
                    Model = r1200rSport,
                    ModelId = r1200rSport.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = spokedWheels.Entity,
                    FeatureId = spokedWheels.Entity.Id,
                    Model = streetScrambler,
                    ModelId = streetScrambler.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = spokedWheels.Entity,
                    FeatureId = spokedWheels.Entity.Id,
                    Model = africaTwin,
                    ModelId = africaTwin.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = spokedWheels.Entity,
                    FeatureId = spokedWheels.Entity.Id,
                    Model = crf250Rally,
                    ModelId = crf250Rally.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = stabilityControl.Entity,
                    FeatureId = stabilityControl.Entity.Id,
                    Model = r1200rSport,
                    ModelId = r1200rSport.Id
                });
                db.ModelFeatures.Add(new ModelFeature() 
                {
                    Feature = leds.Entity,
                    FeatureId = leds.Entity.Id,
                    Model = r1200rSport,
                    ModelId = r1200rSport.Id
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

            }
        }
    }
}
