using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class Factory2 : IFactory
    {
        public ICarColor CreateCarColor()
        {
            return new BlueCarColor();
        }

        public IEngine CreateEngine()
        {
            return new V4Engine();
        }
    }
}
