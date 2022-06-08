using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class Car
    {
        private ICarColor carColor;
        private IEngine engine;

        public Car(ICarColor carColor, IEngine engine)
        {
            this.carColor = carColor;
            this.engine = engine;
        }

        public override string ToString()
        {
            return carColor.Color + " " + engine.Engine;
        }
    }
}
