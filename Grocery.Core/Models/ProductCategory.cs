using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Core.Models
{
    public partial class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId1 { get; set; }
        public int CategoryId { get; set; }
        
        public ProductCategory(int id, string name, int productId1, int categoryId)
        {
            Id = id;
            Name = name;
            ProductId1 = productId1;
            CategoryId = categoryId;
        }
    }
}
