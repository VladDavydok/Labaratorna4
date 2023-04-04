using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    public class Flower
    {
        private string name;
        private string color;
        private double stemLength;
        private int freshnessLevel;

        public Flower(string name, string color, double stemLength, int freshnessLevel)
        {
            this.name = name;
            this.color = color;
            this.stemLength = stemLength;
            this.freshnessLevel = freshnessLevel;
        }

        public string GetName()
        {
            return name;
        }

        public string GetColor()
        {
            return color;
        }

        public double GetStemLength()
        {
            return stemLength;
        }

        public int GetFreshnessLevel()
        {
            return freshnessLevel;
        }
    }
}
