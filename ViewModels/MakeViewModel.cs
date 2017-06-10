using System.Collections.Generic;

namespace Vega.ViewModels
{
    public class MakeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ModelViewModel> Models { get; set; }
    }
}