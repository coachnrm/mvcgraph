using Microsoft.AspNetCore.Mvc;
using SchoolProject.Data;

namespace SchoolProject.Controllers
{
    public class SalesController : Controller
    {
        private ApplicationDbContext _context;

        public SalesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var sales = _context.SalesData.ToList();
            return View(sales);
        }
    }
}