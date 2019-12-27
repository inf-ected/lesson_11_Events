using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        delegate bool IsOk(int Start, int End, int Val);
        delegate int Test(int n);
        static void Main(string[] args)
        {

            //IsOk check = (x, y, v) => v > x && v < y;

            //Console.WriteLine("enter start end and value");
            //var strt = Int32.Parse(Console.ReadLine());
            //var end = Int32.Parse(Console.ReadLine());
            //var val = Int32.Parse(Console.ReadLine());

            //if (check(strt, end, val)) Console.WriteLine("ok!");
            //else Console.WriteLine("NOT ok!");

            //***************************************************************//

            int n = 10;
            Test x = (a) => a * n++;
            Console.WriteLine("{0}", x(5));
            Console.WriteLine("{0}", n);

            Console.ReadKey();

        }
    }
}
