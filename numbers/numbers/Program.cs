using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 0.06f;
            var y = 5.94f;
            var sum = x + y;
            Console.WriteLine("X + Y = {0}", sum);
            

            if (sum.Equals(6))
                Console.WriteLine("X+Y!=6");
            else
                Console.WriteLine("X+Y==6");

            if (x.CompareTo(y) > 0)
                Console.WriteLine("X is greater");
            else
                Console.Write("Y is greater");

            Console.Read();
        }
    }
}
