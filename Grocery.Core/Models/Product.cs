using CommunityToolkit.Mvvm.ComponentModel;

namespace Grocery.Core.Models
{
    public partial class Product : Model
    {
        [ObservableProperty]
        public int stock;
        
        public DateOnly ShelfLife { get; set; }

        public double Prijs { get; set; }
        public int CategoryId { get; set; }
        public Product(int id, string name, int stock, double prijs, int categoryId) : this(id, name, stock, prijs, categoryId, default) { }

        public Product(int id, string name, int stock, double prijs, int categoryId, DateOnly shelfLife) : base(id, name) 
        {
            Stock = stock;
            ShelfLife = shelfLife;
            Prijs = prijs;
            CategoryId = categoryId;

        }
        public override string? ToString()
        {
            return $"{Name} - {Stock} op voorraad";
        }
    }
}
