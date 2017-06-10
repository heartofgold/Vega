using System.Collections.Generic;

namespace Vega.Models
{
    // Represents a feature of a vehicle, for example "Fully adjustable
    // Öhlins electronic suspension". 
    public class Feature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ModelFeature> ModelFeatures { get; set; }
    }
}