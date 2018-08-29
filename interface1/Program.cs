using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Plz key in your score : ");
            int score = int.Parse(Console.ReadLine());

            CTestcs Test = new CTestcs();
            Console.WriteLine(Test.PassOrNot(score));
            Console.WriteLine(Test.GoodOrBad(score));
            Console.ReadKey();
        }
    }
}
