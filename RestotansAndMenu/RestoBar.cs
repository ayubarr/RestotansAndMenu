using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RestouransAndMenu
{
    public class RestoBar
    {
        public string Name { get; set; }    
        public string ChefsName { get; set; }
        public Dictionary<Mealf, double> Mealfs { get; set; }
        public RestoBar(string name, string chefsName, List<Mealf> mealfs)
        {
            Name = name;
            ChefsName = chefsName;
            Mealfs = new Dictionary<Mealf, double>();
            foreach (Mealf meal in mealfs)
            {
                double mealfPrice = Math.Round(meal.MealfPrice * 1.2, 2);
                Mealfs.Add(meal, mealfPrice);
            }
        }
  

        public void ViewRestobarInfo()
        {
            Console.WriteLine(Name.ToUpper());
            Console.WriteLine($"\nChef - {ChefsName}");
            Console.WriteLine("Menu: ");
            Console.WriteLine();
            ViewRestobarMenu();
        }
        public void ViewRestobarMenu()
        {
            foreach (var mealf in Mealfs)
            {
                mealf.Key.ViewProductsAndPrice();
                Console.WriteLine($"{mealf.Key.MealfName} sell price = {mealf.Value} Som");
                Console.WriteLine("_____________________________________________________");
            }
        }
    }
}
