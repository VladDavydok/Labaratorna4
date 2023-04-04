using System.Xml.Linq;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Array a = new Array(5);        
            Array b = new Array(5);

            for (int i = 0; i < 5; i++)
            {
                a[i] = new Element(i);
                b[i] = new Element(i + 1);
            }

            Console.WriteLine("Масив a: " + a);
            Console.WriteLine("Масив b: " + b);

            Array c = a + b;
            Console.WriteLine("Масив c(a + b): " + c);

            Array d = a - b;
            Console.WriteLine("Масив d(a - b): " + d);

            Array e = a * b;
            Console.WriteLine("Масив e(a * b): " + e);

            Console.ReadKey();
        }
    }
}