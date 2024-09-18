using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using FlavourlinesWebApp.Data;

namespace FlavourlinesWebApp.Controllers
{
    public class ReviewController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReviewController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Reviews
        public async Task<IActionResult> Index()
        {
            var reviews = await _context.Reviews.Include(r => r.Product).Include(r => r.User).ToListAsync();
            return View(reviews);
        }

        // GET: Reviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews
                .Include(r => r.Product)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.ReviewId == id);

            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }
    }
}