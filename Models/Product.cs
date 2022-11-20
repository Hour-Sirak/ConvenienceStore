using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMart.Models
{
    public class Product
    {
        public static List<string> Categories 
        { 
            get => new()
            {
                "Household & Cleaning Supplies",
                "Health & Beauty",
                "Food & Beverages",
                "Health Care",
                "Chilled & Frozen",
                "Baby Care",
                "Feeding & Nursery",
                "Fashion",
                "Home & Kitchen",
                "Cooking & Baking Ingredients",
                "Sports & Hobbies",
                "Kitchen & Dining",
                "Tools, DIY & Home Improvement",
                "Office, Administration and Stationeries",
                "Rice, Grains, Pastas & Noodles",
                "Meat, Poultry & Seafood",
                "Snacks",
                "Personal Care",
                "Dairy, Eggs & Milk Substitutes"
            };
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public float PurchasedPrice { get; set; }
        public float SalePrice { get; set; }
        public int UnitInStock { get; set; }

    }
}
