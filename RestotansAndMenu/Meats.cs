using RestouransAndMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RestotansAndMenu
{
    public class Meats : Product
    {
        public Meats(string name, double grammPrice) : base(name, grammPrice)
        {
        }

        public const string Cow_Meat = "Cow Meat";
        public const string Chicken_Meat = "Chicken Meat";
        public const string Fish_Meat = "Fish Meat";
        public const string Pig_Meat = "Pig Meat";
    }

}
