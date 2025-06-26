using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public delegate long SquareDelegate(int side);
    class MulticastDelegates
    {
        public  static long AreaofSquare(int side)
        {
            return side * side;
        }

        public static long PerimeterofSquare(int side)
        {
            return 4 * side;
        }

        static void Main()
        {

            SquareDelegate squareDelegate = new SquareDelegate(AreaofSquare);

            //Console.WriteLine($"Area of the Square:{squareDelegate(5)}");

            squareDelegate += PerimeterofSquare;

            // Console.WriteLine($"Perimeter of the Square{squareDelegate(5)}");

            //Explicit Invokation

            Console.WriteLine($"{squareDelegate.Invoke(5)}");

        }

    }
}
