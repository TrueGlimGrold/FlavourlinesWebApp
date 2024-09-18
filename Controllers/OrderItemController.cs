using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using FlavourlinesWebApp.Data;

namespace FlavourlinesWebApp.Controllers
{
    public class OrderItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OrderItems
        public async Task<IActionResult> Index()
        {
            var orderItems = await _context.OrderItems.Include(oi => oi.Order).Include(oi => oi.Product).ToListAsync();
            return View(orderItems);
        }

        // GET: OrderItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderItem = await _context.OrderItems
                .Include(oi => oi.Order)
                .Include(oi => oi.Product)
                .FirstOrDefaultAsync(m => m.OrderItemId == id);

            if (orderItem == null)
            {
                return NotFound();
            }

            return View(orderItem);
        }
    }
}