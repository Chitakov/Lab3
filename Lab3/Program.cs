using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = 1, f;
            try
            {
            Console.WriteLine("Введите -3<=x<=5");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x >= -3 && x <= -2) f = - x - 2;
            else if (x > -2 && x <= -1) f = Math.Sqrt(Math.Pow(R, 2) - Math.Pow(x + 1, 2));
            else if (x > -1 && x <= 1) f = 1;
            else if (x > 1 && x <= 2) f = - 2 * x + 3;
            else f = -1;
            Console.WriteLine("Для x=" + x);
            Console.WriteLine("f={0}", f);
            Console.ReadLine();
            }
            catch (FormatException)
            { Console.WriteLine("Неверный ввод");
            Console.ReadLine();
            }
        }
    }

}
