using Fiorello_Db.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_Db.Controllers
{
    public class BlogController : Controller
    {
        public AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index() => View(await _context.Blogs.Where(m => !m.SoftDeleted).ToListAsync());

    }
}
