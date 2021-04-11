using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP20
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.15 б
            Console.WriteLine("1.15 б");
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число c");
            double c = Convert.ToDouble(Console.ReadLine());
            double a2 = a/(b * c);
            Console.WriteLine("Ответ;" + a2);
            Console.ReadKey();
        }
    }
}
