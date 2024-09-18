using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using FlavourlinesWebApp.Data;

namespace FlavourlinesWebApp.Controllers
{
    public class PaymentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PaymentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Payments
        public async Task<IActionResult> Index()
        {
            var payments = await _context.Payments.Include(p => p.CustomerOrder).ToListAsync();
            return View(payments);
        }

        // GET: Payments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payment = await _context.Payments
                .Include(p => p.CustomerOrder)
                .FirstOrDefaultAsync(m => m.PaymentId == id);

            if (payment == null)
            {
                return NotFound();
            }

            return View(payment);
        }
    }
}