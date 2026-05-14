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
    public class User
    {
        public int Id { get; set; } //mã
        public string Username { get; set; }// tên người dùng
        public string PasswordHash { get; set; }// mật khẩu
        public string FullName { get; set; }// Họ và tên
        public string Role { get; set; } // Quản trị viên hoặc Biên tập viên
    }
}
