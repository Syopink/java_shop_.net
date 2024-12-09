using System;

namespace Vietpro_Shop.Models
{
    public class Product
    {
        public int IdProduct { get; set; }
        public string IdCate { get; set; }
        public string CategoryTitle { get; set; }  // Thêm thuộc tính CategoryTitle
        public string Name { get; set; }
        public string Thumbnail { get; set; }
        public string Descriptions { get; set; }
        public decimal Price { get; set; }  // BigDecimal trong Java được thay bằng decimal trong C#
        public string Status { get; set; }
        public bool Featured { get; set; }
        public string Promotion { get; set; }
        public string Warranty { get; set; }
        public string Accessories { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Constructor không tham số
        public Product()
        {
        }

        // Constructor không có CategoryTitle
        public Product(string idCate, string name, string thumbnail, string descriptions, decimal price, string status)
        {
            IdCate = idCate;
            Name = name;
            Thumbnail = thumbnail;
            Descriptions = descriptions;
            Price = price;
            Status = status;
        }

        // Constructor đầy đủ
        public Product(int idProduct, string idCate, string categoryTitle, string name, string thumbnail, string descriptions,
                       decimal price, string status, bool featured, string promotion, string warranty,
                       string accessories, DateTime createdAt, DateTime updatedAt)
        {
            IdProduct = idProduct;
            IdCate = idCate;
            CategoryTitle = categoryTitle;
            Name = name;
            Thumbnail = thumbnail;
            Descriptions = descriptions;
            Price = price;
            Status = status;
            Featured = featured;
            Promotion = promotion;
            Warranty = warranty;
            Accessories = accessories;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        // toString method để hiển thị thông tin sản phẩm
        public override string ToString()
        {
            return $"Product{{" +
                   $"IdProduct={IdProduct}, " +
                   $"IdCate='{IdCate}', " +
                   $"CategoryTitle='{CategoryTitle}', " +
                   $"Name='{Name}', " +
                   $"Thumbnail='{Thumbnail}', " +
                   $"Descriptions='{Descriptions}', " +
                   $"Price={Price}, " +
                   $"Status='{Status}', " +
                   $"Featured={Featured}, " +
                   $"Promotion='{Promotion}', " +
                   $"Warranty='{Warranty}', " +
                   $"Accessories='{Accessories}', " +
                   $"CreatedAt={CreatedAt}, " +
                   $"UpdatedAt={UpdatedAt}" +
                   "}}";
        }
    }
}
