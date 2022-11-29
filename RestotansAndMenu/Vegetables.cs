using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestotansAndMenu
{
    internal class Vegetables : Product
    {
        public Vegetables(string name, double grammPrice) : base(name, grammPrice)
        {

        }
        public const string Tomato = "Tomato";
        public const string Cucumber = "Cucumber";
        public const string Onion = "Onion";
        public const string Lettuce_Leaf = "Lettuce Leaf";


    }
}
