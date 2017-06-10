using System.Collections.Generic;

namespace Vega.Models
{
    // This is to implement the many-to-many relationship between models
    // and features, with Entity Framework Core.
    public class ModelFeature
    {
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public int FeatureId { get; set; }
        public Feature Feature { get; set; }
    }
}