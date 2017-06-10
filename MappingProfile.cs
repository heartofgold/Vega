using System;
using AutoMapper;
using Vega.Models;
using Vega.ViewModels;

namespace Vega 
{
    public class MappingProfile : Profile
    {
        public MappingProfile() : this("MyProfile")
        {
        }

        protected MappingProfile(string profileName) : base(profileName)
        {
            CreateMap<ModelViewModel, Model>();
            CreateMap<Model, ModelViewModel>();
            CreateMap<MakeViewModel, Make>();
            CreateMap<Make, MakeViewModel>();
            CreateMap<FeatureViewModel, Feature>();
            CreateMap<Feature, FeatureViewModel>();
        }
    }
}