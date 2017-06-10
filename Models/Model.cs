using System.Collections.Generic;

namespace Vega.Models
{
    // Represents a vehicle... Ok, it's really a motorcycle because do we care
    // about anything else? No we don't 8).
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MakeId { get; set; }
        public Make Make { get; set; }
        public int Year { get; set; }
        public string ImageUrl { get; set; }
        public string EngineType { get; set; }
        public int Displacement { get; set;}
        public string BoreAndStroke { get; set; }
        public string CompressionRatio { get; set; }
        public string MaxPower { get; set; }
        public string MaxTorque { get; set; }
        public string Lubrication { get; set; }
        public string ClutchType { get; set; }
        public string Carburettor { get; set; }
        public string Ignition { get; set; }
        public string Starter { get; set; }
        public string Transmission { get; set; }
        public string FinalDrive { get; set; }
        public string FuelConsumption { get; set; }
        public string Frame { get; set; }
        public string FrontSuspension { get; set; }
        public string RearSuspension { get; set; }
        public string FrontBrake { get; set; }
        public string RearBrake { get; set; }
        public string FrontTyre { get; set; }
        public string RearTyre { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public double? SeatHeight { get; set; }
        public double? WheelBase { get; set; }
        public double? GroundClearance { get; set; }
        public double? FuelCapacity { get; set; }
        public double? WetWeight { get; set; }  
        public ICollection<ModelFeature> ModelFeatures { get; set; }
    }
}