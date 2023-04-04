using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    public class Carnation : Flower
    {
        private string aroma;

        public Carnation(string name, string color, double stemLength, int freshnessLevel, string aroma) : base(name, color, stemLength, freshnessLevel)
        {
            this.aroma = aroma;
        }

        public string GetAroma()
        {
            return aroma;
        }
    }
}
