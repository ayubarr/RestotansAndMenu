using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestotansAndMenu
{
    public class Product
    {
        public string Name { get; set; }
        public double GrammPrice { get; set; }
        public Product(string name, double grammPrice)
        {
            Name = name;
            GrammPrice = grammPrice;
        }
        public void ViewEveryUsed()
        {
            double totalWeight = Math.Round(TotalUsing / 1000, 3);
            Console.Write($"Total weight of {Name} in all meals in every restaurant is {totalWeight} kilos\n");
        }
        public double TotalUsing { get; set; }

    }
}
