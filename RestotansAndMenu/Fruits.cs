using RestotansAndMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestouransAndMenu
{
    public class Fruits : Product
    {
        public Fruits(string name, double grammPrice) : base(name, grammPrice)
        {

        }
        public const string Apple = "Apple";
        public const string Orange = "Orange";
        public const string Grape = "Grape";
        public const string Banana = "Banana";
    }
}
