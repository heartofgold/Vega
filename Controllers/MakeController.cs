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
    public class MakeController : Controller
    {
        private readonly VegaDbContext _context;
        private readonly IMapper _mapper;

        public MakeController(VegaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("/api/makes")]
        public IEnumerable<MakeViewModel> GetMakes()
        {
            var makes = _context.Makes.Include(m => m.Models).ToList();
            return _mapper.Map<IList<Make>, IList<MakeViewModel>>(makes);
        }
    }
}