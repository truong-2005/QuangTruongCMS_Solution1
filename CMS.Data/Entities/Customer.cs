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
    // Khách hàng
    public class Customer
    {
        [Key]
        public int Id { get; set; }// mã

        [Required]
        public string FullName { get; set; }// Họ Tên

        [Required]
        [EmailAddress]
        public string Email { get; set; }//địa chỉ email

        public string? Phone { get; set; }// sđt

        public string? Address { get; set; }//địa chỉ

        [Required]
        public string Password { get; set; } // Lưu mật khẩu thô theo yêu cầu tối giản

        public virtual ICollection<Order>? Orders { get; set; }
    }
}


