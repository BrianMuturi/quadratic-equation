using System;

namespace quadratic_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, a, b, c, x;
            Console.Write("a:" );
            a = double.Parse(Console.ReadLine());
            Console.Write("b:" );
            b = double.Parse(Console.ReadLine());
            Console.Write("x:" );
            x = double.Parse(Console.ReadLine());
            Console.Write("c:");
            c = double.Parse(Console.ReadLine());
            y = (a * (x * x)) + (b * x) + c;
            Console.Write("y="  + y);
            
        }
    }
}
