using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Vega.Models;
using Vega.Data;
using Vega.ViewModels;

namespace Vega.Controllers
{
    public class FeatureController : Controller
    {
        private readonly VegaDbContext _context;
        private readonly IMapper _mapper;

        public FeatureController(VegaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        [HttpGet("/api/features")]
        public async Task<IActionResult> GetFeatures()
        {
            var features = await _context.Features.ToListAsync();
            return Ok(_mapper.Map<IList<Feature>, IList<FeatureViewModel>>(features));
        } 
    }
}