using System;

namespace LAB2ASS
{
    class Program
    {
        static void Main(string[] args)
        {
           //lab2 A
           int age = 56;
           double number = 45.976578;
           float a = 67.4f; 
           decimal b = 45.8m;
           string name = "Evan";
           char c = 'b';
           bool d = true;
           long e = -78L;
           short f = 67;
           byte g = 20;

            Console.WriteLine(age);
            Console.WriteLine(number);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(name);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
          
           //B (Example of implicit and explicit conversions)
           //implicit
           int num_a = 45;
           float num_b = num_a;
           Console.WriteLine(num_b);

            //explicit
           float num_c = 789.9897f;
           int num_d = (int) num_c;
           Console.WriteLine(num_d);
           



        }
    }
}
