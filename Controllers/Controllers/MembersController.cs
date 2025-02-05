using Microsoft.AspNetCore.Mvc;
using FitnessApp.Data;
using FitnessApp.Models;
using System.Linq;

namespace FitnessApp.Controllers
{
    public class MembersController : Controller
    {
        private readonly AppDbContext _context;

        public MembersController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var members = _context.Members.ToList();
            return View(members);
        }
    }
}
