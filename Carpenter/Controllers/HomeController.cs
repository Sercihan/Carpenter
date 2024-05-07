using Carpenter.Models;
using Carpenter.ORM.Context;
using Carpenter.ORM.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Carpenter.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Feature()
        {
            return View();
        }
        public IActionResult Project()
        {
            return View();
        }
        public IActionResult Quote()
        {
            return View();
        }
        public IActionResult Service()
        {
            List<Service> TempService = db.Services.ToList();
            return View(TempService);
        }
        public IActionResult Team()
        {
            List<Team> TempTeam = db.teams.ToList();
            return View(TempTeam);
        }
        public IActionResult Testimonial()
        {
            List<Testimonial> TempTestimonial = db.testimonials.ToList();
            return View(TempTestimonial);
        }
    }
}
