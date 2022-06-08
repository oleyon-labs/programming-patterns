using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class V4Engine : IEngine
    {
        public V4Engine()
        {
            Engine = "V4";
        }

        public string Engine { get; }
    }
}
