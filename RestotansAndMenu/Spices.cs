using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestotansAndMenu
{
    internal class Spices : Product
    {
        public Spices(string name, double grammPrice) : base(name, grammPrice)
        {

        }
        public const string Solt = "Solt";
        public const string Pepper = "Pepper";
        public const string Ketchup = "Ketchup";
    }
}
