using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using FlavourlinesWebApp.Data;
using FlavourlinesWebApp.Models;

namespace FlavourlinesWebApp.Controllers
{
    public class CustomerOrderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerOrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            var orders = await _context.CustomerOrders
        .Include(o => o.User) // Include related User data
        .OrderBy(o => o.OrderDate) // Order by OrderDate
        .ToListAsync(); // Retrieve the list asynchronously
            return View(orders); // Pass the ordered list to the view
        }

        // GET: CustomerOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerOrder = await _context.CustomerOrders
                .Include(o => o.User)
                .Include(o => o.Payment) // Assuming you want to include Payment
                .FirstOrDefaultAsync(m => m.CustomerOrderId == id); // Corrected to OrderId

            if (customerOrder == null)
            {
                return NotFound();
            }

            return View(customerOrder);
        }
    }
}