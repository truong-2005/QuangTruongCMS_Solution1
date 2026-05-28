using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // BẮT BUỘC thêm dòng này để dùng được hàm Include
using System.Linq;
using CMS.Data;
using CMS.Data.Entities;

namespace CMS.Backend.Controllers
{
    public class PostController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PostController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Action Index hỗ trợ lọc theo mã danh mục (id nhận từ URL dạng: /Post/Index/1)
        public IActionResult Index(int? id)
        {
            // Khởi tạo câu lệnh truy vấn, nạp chồng (Join) sẵn bảng Category
            var query = _context.Posts.Include(p => p.Category).AsQueryable();

            // Lọc dữ liệu nếu người dùng có truyền ID danh mục cụ thể trên URL
            if (id != null)
            {
                query = query.Where(p => p.CategoryId == id);
            }

            // Sắp xếp bài viết theo ngày tạo mới nhất lên đầu và chuyển thành List
            var posts = query.OrderByDescending(p => p.CreatedDate).ToList();

            return View(posts);
        }

        // =================================================================
        // CODE CẬP NHẬT CHỨC NĂNG XEM CHI TIẾT BÀI VIẾT (Details) Ở ĐÂY
        // =================================================================
        // Đường dẫn chạy thực tế trên trình duyệt: /Post/Details/5
        public IActionResult Details(int id)
        {
            // 1. Tìm bài viết đầu tiên khớp với ID, đồng thời nạp kèm bảng Category (Join bảng)
            var post = _context.Posts
                .Include(p => p.Category)
                .FirstOrDefault(p => p.Id == id);

            // 2. Chốt chặn bảo vệ: Nếu không tìm thấy bài viết nào có ID này, trả về trang lỗi 404
            if (post == null)
            {
                return NotFound();
            }

            // 3. Truyền dữ liệu của bài viết tìm được ra ngoài View Details.cshtml để hiển thị
            return View(post);
        }
    }
}