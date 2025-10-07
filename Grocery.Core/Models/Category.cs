using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Core.Models
{
    public class Category
    {
        int Id { get; set; }
        string Name { get; set; }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
