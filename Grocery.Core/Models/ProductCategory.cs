using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Core.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        public ProductCategory(int id, string productname, int productId, int categoryId)
        {
            Id = id;
            ProductName = productname;
            ProductId = productId;
            CategoryId = categoryId;
        }

        public ProductCategory() { }
    }
}
