using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите точность");
            double ep = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите начало отрезка");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите конец отрезка");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите шаг");
            double h = Convert.ToDouble(Console.ReadLine());
            double x = a, s, y;
            const int MaxIter = 500;
            bool done = true;
            int i;
            int j = 0;
            while (h * Math.Pow(10, 1 + j) % 10 != 0) { j++; }
            Console.WriteLine(" __________________________________________________");
            Console.WriteLine("|  x  |    Сумма ряда    |  n  |    Зн. функции   |");
            Console.WriteLine(" __________________________________________________");
            while (x <= b)
            {
                s = x; y = s;
                done = true;
                for (i = 1; Math.Abs(s) > ep; i++)
                {
                    s *= Math.Pow(x, 2) * (2 * i - 1) / (2 * i + 1);
                    y += s;
                    if (i > MaxIter) { done = false; break; }
                }
                if (done == true) Console.WriteLine("|{0,5}|{1,18}|{2,5}|{3,18}| ", x, y, i, Math.Log((1 + x) / (1 - x)) / 2);// Math.Atan(x));
                else Console.WriteLine("|{0,5}|  Ряд расходится  |     |                  ", x);
                x += h;
                x = Math.Round(x, j);
            }
            Console.WriteLine(" __________________________________________________");
            Console.ReadLine();
        }
    }
}
