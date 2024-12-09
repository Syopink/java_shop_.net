using System;

namespace Vietpro_Shop.Models
{
    internal class Cate
    {
        // Thuộc tính Id và Title
        public int Id { get; set; }
        public string Title { get; set; }

        // Constructor để khởi tạo đối tượng Cate
        public Cate(int id, string title)
        {
            Id = id;
            Title = title;
        }

        // Constructor không tham số (optional)
        public Cate() { }
    }
}
