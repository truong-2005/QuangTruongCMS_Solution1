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

using System.ComponentModel.DataAnnotations;
namespace CMS.Data.Entities
{

    public class CategoryProduct
    {
        [Key]
        public int Id { get; set; }// mã

        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [StringLength(100)]
        public string Name { get; set; }//tên

        public string? Description { get; set; }//mô tả

        // Quan hệ: Một danh mục có nhiều sản phẩm
        public virtual ICollection<Product>? Products { get; set; }
    }
}
