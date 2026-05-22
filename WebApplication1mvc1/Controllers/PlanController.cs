using ClassLibrary1.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApplication1mvc1.DbContexts;
namespace WebApplication1mvc1.Controllers
{
    public class PlanController : Controller
    {
        //private readonly GymDbContext _context = new GymDbContext();
        private readonly IPlanRepository _planRepository;
        public PlanController(IPlanRepository planRepository)
        {
            _planRepository = planRepository;
        }
        public async Task<IActionResult> Index(CancellationToken ct=default)
        {
            //var plans = await _context.Plans.ToListAsync();
            var plans = await _planRepository.GetAllAsync(ct: ct);
            return View(plans);
        }
        public async Task<IActionResult> Details(int id , CancellationToken ct=default)
        {
            //var plan = await _context.Plans.FirstOrDefaultAsync(P => P.Id ==    id);
            var plan = await _planRepository.GetByIdAsync(id, ct);
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
