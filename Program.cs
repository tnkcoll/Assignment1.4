using System.Runtime.InteropServices;

namespace Assignment1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point P1 = new Point();
            Point P2 = new Point();

            if (P1.x == P2.x)
            {
                Console.WriteLine("Points are on the same axis.");
            }
            else 
            { 
                Console.WriteLine("Points are not on the same axis.");
            }
            
        }

        public struct Point
        {
            public double x;
            public double y;

        }

    }
}
