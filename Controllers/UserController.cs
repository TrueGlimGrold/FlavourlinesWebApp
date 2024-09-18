using FlavourlinesWebApp.Models; // Ensure this namespace includes your User class
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class UserController : Controller
{
    private readonly UserManager<User> _userManager;

    public UserController(UserManager<User> userManager)
    {
        _userManager = userManager;
    }

    // GET: Users
    public IActionResult Index()
    {
        var users = _userManager.Users; // Get all custom User instances
        return View(users);
    }

    // GET: Users/Details/5
    public async Task<IActionResult> Details(string id)
    {
        if (string.IsNullOrEmpty(id))
        {
            return NotFound();
        }

        var user = await _userManager.FindByIdAsync(id);
        if (user == null)
        {
            return NotFound();
        }

        return View(user);
    }
}