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
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Data.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }//mã

        public DateTime OrderDate { get; set; } = DateTime.Now;//ngày

        public int CustomerId { get; set; }// mã kh

        public int Status { get; set; } // 0: Chờ duyệt, 1: Đang giao, 2: Đã xong

        public string? Notes { get; set; }//ghi chú

        [ForeignKey("CustomerId")]
        public virtual Customer? Customer { get; set; }

        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
