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
    public class Category
    {
        public int Id { get; set; } //mã
        public string Name { get; set; }//tên // Tên danh mục (vd: Tin Giáo Dục)
        public string Description { get; set; }//mô tả

        // Quan hệ: Một danh mục có nhiều bài viết
        public virtual ICollection<Post> Posts { get; set; }
    }
}
