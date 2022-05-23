using A.NTask1.DAL;
using A.NTask1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.NTask1.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Category()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

    }
}
