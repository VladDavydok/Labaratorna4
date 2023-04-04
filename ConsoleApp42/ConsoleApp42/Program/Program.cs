
namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            Rose redRose = new Rose("Червона Роза", "червоний", 40, 5, true);
            Tulip yellowTulip = new Tulip("Жовтий Тюльпан", "жовтий", 30, 7, false);
            Carnation whiteCarnation = new Carnation("Бiла Гвоздика", "бiлий", 25, 4, "пряний");
            Tulip pinkTulip = new Tulip("Рожевий Тюльпан", "рожевий", 35, 6, true);

            List<Flower> flowers = new List<Flower>();
            flowers.Add(redRose);
            flowers.Add(yellowTulip);
            flowers.Add(whiteCarnation);
            flowers.Add(pinkTulip);
            Bouquet bouquet = new Bouquet(flowers);


            Console.WriteLine("Вартiсть букету: $" + bouquet.GetPrice());

            bouquet.SortByFreshnessLevel();

            Console.WriteLine("Букет вiдсортований за ступенем свiжостi:");
            foreach (Flower flower in flowers)
            {
                Console.WriteLine("- " + flower.GetName() + " (" + flower.GetFreshnessLevel() + ")");
            }

            double minLength = 30;
            double maxLength = 40;
            int count;
            List<Flower> matchingFlowers = bouquet.FindFlowersByStemLength(minLength, maxLength, out count);
            Console.WriteLine("Iснує " + count + " квiтiв в букетi з довжиною стебла мiж " + minLength + " та " + maxLength + ":");
            foreach (Flower flower in matchingFlowers)
            {
                Console.WriteLine("- " + flower.GetName() + " (" + flower.GetStemLength() + ")");
            }

            Console.ReadLine();
        }
    }
}