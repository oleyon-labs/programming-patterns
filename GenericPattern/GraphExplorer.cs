using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPattern
{
    internal abstract class GraphExplorer
    {
        public void Search()
        {

        }
        public abstract void StartOfTheCrawl();
        public abstract void EndOfTheTour();
        public abstract void VisitNodeV();
        public abstract void VisitRibE();
    }
}
