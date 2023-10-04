using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AvaevaPD.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.AvaevaPD.Sprint0.TaskReview.V2
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 5;
            Console.WriteLine("Значение x");
            Console.WriteLine(x);

            int y = 10;
            Console.WriteLine("Значение y");
            Console.WriteLine(y);

            int z = 15;
            Console.WriteLine("Значение z");
            Console.WriteLine(z);


            Console.WriteLine("Результат:" + DataService.Calculate(x, y, z));
            Console.ReadLine();
        }
    }
}
