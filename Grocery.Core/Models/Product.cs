using CommunityToolkit.Mvvm.ComponentModel;

namespace Grocery.Core.Models
{
    public partial class Product : Model
    {
        [ObservableProperty]
        public int stock;
        
        public DateOnly ShelfLife { get; set; }

        public double Prijs { get; set; }
        public Product(int id, string name, int stock, double prijs) : this(id, name, stock, prijs, default) { }

        public Product(int id, string name, int stock, double prijs, DateOnly shelfLife) : base(id, name) 
        {
            Stock = stock;
            ShelfLife = shelfLife;
            Prijs = prijs;
        }
        public override string? ToString()
        {
            return $"{Name} - {Stock} op voorraad";
        }
    }
}
