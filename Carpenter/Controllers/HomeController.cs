using Carpenter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Carpenter.Controllers
{
    public class HomeController : Controller
    {
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
            return View();
        }
        public IActionResult Team()
        {
            return View();
        }
        public IActionResult Testimonial()
        {
            return View();
        }
    }
}
