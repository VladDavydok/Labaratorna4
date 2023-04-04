using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    public class Rose : Flower
    {
        private bool hasThorns;

        public Rose(string name, string color, double stemLength, int freshnessLevel, bool hasThorns) : base(name, color, stemLength, freshnessLevel)
        {
            this.hasThorns = hasThorns;
        }

        public bool HasThorns()
        {
            return hasThorns;
        }
    }
}
