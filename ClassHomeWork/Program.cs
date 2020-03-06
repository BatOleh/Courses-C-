using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHomeWork
{
    class Text
    {
        public String S="";
        public Text()
        {
            //S = "Here is the fashion to be your ad :)";
            S = Console.ReadLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Text ad = new Text();
            Console.WriteLine(ad.S);
            Console.ReadKey();
        }
    }
}
