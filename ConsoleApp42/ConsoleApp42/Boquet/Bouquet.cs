using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    public class Bouquet
    {
        private List<Flower> flowers;

        public Bouquet(List<Flower> flowers)
        {
            this.flowers = flowers;
        }

        public void AddFlower(Flower flower)
        {
            flowers.Add(flower);
        }

        public double GetPrice()
        {
            double price = 0;
            foreach (Flower flower in flowers)
            {
                price += CalculateFlowerPrice(flower);
            }
            return price;
        }

        private double CalculateFlowerPrice(Flower flower)
        {
            double price = 0;
            if (flower is Rose)
            {
                price = 10;
                if (((Rose)flower).HasThorns())
                {
                    price += 2;
                }
            }
            else if (flower is Tulip)
            {
                price = 7;
                if (((Tulip)flower).IsDouble())
                {
                    price += 3;
                }
            }
            else if (flower is Carnation)
            {
                price = 5;
                if (((Carnation)flower).GetAroma() == "spicy")
                {
                    price += 2;
                }
            }
            return price;
        }

        public void SortByFreshnessLevel()
        {
            flowers.Sort((flower1, flower2) => flower1.GetFreshnessLevel().CompareTo(flower2.GetFreshnessLevel()));
        }

        public List<Flower> FindFlowersByStemLength(double minLength, double maxLength, out int count)
        {
            count = 0;
            List<Flower> matchingFlowers = new List<Flower>();
            foreach (Flower flower in flowers)
            {
                if (flower.GetStemLength() >= minLength && flower.GetStemLength() <= maxLength)
                {
                    matchingFlowers.Add(flower);
                    count++;
                }
            }
            return matchingFlowers;
        }
    }
}
