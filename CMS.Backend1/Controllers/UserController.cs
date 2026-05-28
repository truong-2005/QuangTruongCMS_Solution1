using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CMS.Data; // Thêm dòng này để gọi database context
using CMS.Data.Entities;

namespace CMS.Backend.Controllers
{
    public class UserController : Controller
    {
        // Khai báo biến kết nối database
        private readonly ApplicationDbContext _context;

        // Thực hiện "Tiêm" kết nối vào Controller (Constructor Injection)
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Hàm Index: Hiển thị danh sách thành viên THẬT từ SQL Server
        public IActionResult Index()
        {
            // Lấy toàn bộ người dùng từ bảng Users trong SQL
            var users = _context.Users.ToList();

            // Trả về View kèm theo danh sách người dùng thật
            return View(users);
        }
    }
}