using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class V8Engine : IEngine
    {
        public V8Engine()
        {
            Engine = "V8";
        }

        public string Engine { get; }
    }
}
