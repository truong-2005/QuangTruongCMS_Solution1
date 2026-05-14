/*
 *Họ tên:Nguyễn Quang Trường
 *Lớp:CCQ2311C
 *Phiên bản:1.0
 *MSSV:2123110098
 *Ngày tạo:14/05/2026
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } // Tiêu đề bài viết
        public string Content { get; set; } // Nội dung chi tiết
        public string ImageUrl { get; set; } // Hình ảnh đại diện
        public DateTime CreatedDate { get; set; } = DateTime.Now;//ngày tạo

        // Khóa ngoại liên kết tới Category
        public int CategoryId { get; set; } //mã cate
        public virtual Category Category { get; set; }
    }
}

