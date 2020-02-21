using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int y;
            double p, S, Sn;
            Console.Write("Enter years: ");
            y = Int32.Parse(Console.ReadLine());
            Console.Write("Enter persents: ");
            p = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Sum: ");
            S = Int32.Parse(Console.ReadLine());
            Sn = (S + (S * (p / 100.0)*y));
            Console.WriteLine("Sum after "+y+" years = "+Sn);
            Console.ReadKey();
        }
    }
}
