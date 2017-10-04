using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;

            Console.WriteLine("Введите A: ");
            Program.Checker(ref a);

            Console.WriteLine("Введите B: ");
            Program.Checker(ref b);

            Console.WriteLine("Введите C: ");
            Program.Checker(ref c);

            double d = b * b - 4 * a * c;

            if (d > 0)
                Console.WriteLine("Корни уравнения: " + (-1 * b + Math.Sqrt(d)) / 2 / a + " и " + (-1 * b - Math.Sqrt(d)) / 2 / a);
            else if (d == 0)
                Console.WriteLine("Корень уравнения: " + (-1 * b / 2 / a));
            else
                Console.WriteLine("Корней нет");

            Console.ReadLine();
        }

        static void Checker(ref double temp)
        {
            bool warn;
            temp = 0;

            do
            {
                warn = false;
                string enter = Console.ReadLine();

                try
                {
                    temp = double.Parse(enter);
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка ввода. Повтор: ");
                    warn = true;
                }
            }
            while (warn == true);
        }
    }
}
