using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTickets.Data;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext contex)
        {
            _context = contex;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Movies.ToListAsync();
            return View();
        }
    }
}
