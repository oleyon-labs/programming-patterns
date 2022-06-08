using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class RedCarColor : ICarColor
    {
        public string Color { get; }
        public RedCarColor()
        {
            Color = "Red";
        }
    }
}
