using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первое число");
                decimal a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите первое число");
                decimal b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции:\r\n\t1 - сложение\r\n\t2 - вычитание\r\n\t3 - произведение\r\n\t4 - частное");
                decimal c = Convert.ToInt32(Console.ReadLine());

                if (c < 1 || c > 4)
                {
                    Console.WriteLine("Нет операции с таким номером");
                }
                if (c == 1)
                {
                    Console.WriteLine("Ваш выбор - сложение");
                    Console.WriteLine("{0}+{1}={2}", a, b, a + b);
                }
                if (c == 2)
                {
                    Console.WriteLine("Ваш выбор - вычитание");
                    Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                }
                if (c == 3)
                {
                    Console.WriteLine("Ваш выбор - произведение");
                    Console.WriteLine("{0}*{1}={2}", a, b, a * b);
                }
                if (c == 4)
                {
                    Console.WriteLine("Ваш выбор - частное");
                    Console.WriteLine("{0}/{1}={2:f2}", a, b, a / b);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
