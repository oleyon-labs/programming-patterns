using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class Factory1 : IFactory
    {
        public ICarColor CreateCarColor()
        {
            return new RedCarColor();
        }

        public IEngine CreateEngine()
        {
            return new V8Engine();
        }
    }
}
