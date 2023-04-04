using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    class Array
    {
        private Element[] elements;

        public Array(int size)
        {
            elements = new Element[size];
        }

        public Element this[int index]
        {
            get { return elements[index]; }
            set { elements[index] = value; }
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < elements.Length; i++)
            {
                result += elements[i] + " ";
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Array other = (Array)obj;
            if (elements.Length != other.elements.Length)
            {
                return false;
            }
            for (int i = 0; i < elements.Length; i++)
            {
                if (!elements[i].Equals(other.elements[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            int result = 17;
            for (int i = 0; i < elements.Length; i++)
            {
                result = result * 31 + elements[i].GetHashCode();
            }
            return result;
        }

        public static Array operator +(Array a, Array b)
        {
            if (a.elements.Length != b.elements.Length)
            {
                throw new ArgumentException("Масиви мусять мати однакову довжину.");
            }
            Array result = new Array(a.elements.Length);
            for (int i = 0; i < a.elements.Length; i++)
            {
                result.elements[i] = new Element(a.elements[i].Value + b.elements[i].Value);
            }
            Console.WriteLine("Масиви додано:");
            return result;
        }

        public static Array operator -(Array a, Array b)
        {
            if (a.elements.Length != b.elements.Length)
            {
                throw new ArgumentException("Масиви мусять мати однакову довжину.");
            }
            Array result = new Array(a.elements.Length);
            for (int i = 0; i < a.elements.Length; i++)
            {
                result.elements[i] = new Element(a.elements[i].Value - b.elements[i].Value);
            }
            Console.WriteLine("Масиви вiднято:");
            return result;
        }

        public static Array operator *(Array a, Array b)
        {
            if (a.elements.Length != b.elements.Length)
            {
                throw new ArgumentException("Масиви мусять мати однакову довжину.");
            }
            Array result = new Array(a.elements.Length);
            for (int i = 0; i < a.elements.Length; i++)
            {
                result.elements[i] = new Element(a.elements[i].Value * b.elements[i].Value);
            }
            Console.WriteLine("Масиви було помножено:");
            return result;
        }
    }
}
