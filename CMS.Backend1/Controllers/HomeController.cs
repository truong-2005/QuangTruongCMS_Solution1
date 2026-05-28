using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CMS.Data; // Th? m?c ch?a DbContext
using System.Linq;

namespace CMS.Backend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // LINQ: Gi? nguy�n 100% code c?a th?y, kh�ng thay ??i m?t ch?
            var latestPosts = _context.Posts
                                .Include(p => p.Category) // L?y k�m t�n danh m?c ?? hi?n th? 
                                .OrderByDescending(p => p.CreatedDate) // S?p x?p ng�y m?i nh?t l�n ??u 
                                .Take(3) // Ch? l?y ?�ng 3 b?n tin ??u ti�n
                                .ToList();

            return View(latestPosts);
        }
    }
}