using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApplication1mvc1.DbContexts;
namespace WebApplication1mvc1.Controllers
{
    public class PlanController : Controller
    {
        private readonly GymDbContext _context = new GymDbContext();
        public async Task<IActionResult> Index()
        {
            var plans = await _context.Plans.ToListAsync();
            return View(plans);
        }
        public async Task<IActionResult> Details(int id)
        {
            var plan = await _context.Plans.FirstOrDefaultAsync(P => P.Id ==    id);
            if (plan is null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(plan);
            }
                
        }
    }
} 
