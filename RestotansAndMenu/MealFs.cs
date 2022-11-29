using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestotansAndMenu;

namespace RestouransAndMenu
{
    public class Mealf
    {
        public string MealfName { get; set; }
        public double MealfPrice  { get; set; }
        public double MealfWeight { get; set; }
        public Mealf(string name, Dictionary<Product, double> products)
        {
            MealfName = name;
            Products = products;

            MealfPrice = 0;
            foreach (var option in products)
            {
                MealfWeight += option.Value;
                MealfPrice += (option.Value * option.Key.GrammPrice) / 100;
                option.Key.TotalUsing += option.Value;
            }
            MealfWeight = Math.Round(MealfWeight, 2);
            MealfPrice = Math.Round(MealfPrice, 2);

        }
        public void ViewProductsPricesAtGram()
        {
            Console.WriteLine($"{MealfName}: ");
            foreach(var product in Products)
            {
                Console.WriteLine($"{product.Key.Name} - {product.Key.GrammPrice}");
            }
        }
        public void ViewProductsAndPrice()
        {
            Console.Write($"{MealfName}: ");
            Console.WriteLine();
            Console.WriteLine();

            ViewProductPriceAtSoms();

            Console.WriteLine("_____________________________________________________");
            Console.WriteLine($"Total price = {MealfPrice} Som");
            Console.WriteLine($"Total weight = {MealfWeight} grams");
            Console.WriteLine("_____________________________________________________");
        }
        public void ViewProductPriceAtSoms()
        {
            foreach (var product in Products)
            {
                double price = product.Key.GrammPrice * 0.1;
                Console.WriteLine($"{product.Key.Name} - {product.Value} grams - {price} Som");
            }
        }

        public Dictionary<Product, double> Products = new Dictionary<Product, double>();

        public const string Assorti_Kebab = "Kebab Mix";
        public const string Fruit_Salad = "Fruit Salad";
        public const string Cow_Kebab = "Cow Kebab";
        public const string Chicken_Kebab = "Chicken Kebab";
    }
}
