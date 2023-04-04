using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    public class Tulip : Flower
    {
        private bool isDouble;

        public Tulip(string name, string color, double stemLength, int freshnessLevel, bool isDouble) : base(name, color, stemLength, freshnessLevel)
        {
            this.isDouble = isDouble;
        }

        public bool IsDouble()
        {
            return isDouble;
        }
    }
}
