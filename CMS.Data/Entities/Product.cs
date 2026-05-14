/*
 *Họ tên:Nguyễn Quang Trường
 *Lớp:CCQ2311C
 *Phiên bản:1.0
 *MSSV:2123110098
 *Ngày tạo:14/05/2026
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CMS.Data.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }//mã

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        public string Name { get; set; }//tên

        public string? Description { get; set; }//mô tả

        [Range(0, double.MaxValue)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }//giá

        public int StockQuantity { get; set; }//số lượng

        public string? ImageUrl { get; set; }//ảnh

        // Khóa ngoại nối tới CategoryProduct
        public int CategoryProductId { get; set; }// mã cateproductid

        [ForeignKey("CategoryProductId")]
        public virtual CategoryProduct? CategoryProduct { get; set; }
