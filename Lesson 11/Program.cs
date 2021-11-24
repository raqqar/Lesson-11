using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    class Program
    {
        //Разработать структуру для решения линейного уравнения 0=kx+b. Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.
        //Для решения уравнения предусмотреть метод Root.
        //Создать экземпляр разработанной структуры. Осуществить использование экземпляра в программе.
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Для решения линейного уравнения 0=kx+b");
                Console.Write("Введите коэффициент уравнения k ");
                double k = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите коэффициент уравнения b ");
                double b = Convert.ToInt32(Console.ReadLine());

                LeR ler = new LeR(k, b);
                ler.Root();

                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        public struct LeR
        {
            public LeR(double firstCoef, double secondCoef)
            {
                k = firstCoef;
                b = secondCoef;
                x = 0;
            }

            public double k;
            public double b;
            public double x;
            public void Root()
            {
                if (k != 0)
                {
                    x = -b / k;
                    Console.WriteLine("X = {0}",x);
                }
                else if (b != 0)
                {
                    Console.WriteLine("Корни отсутствуют!");

                }
                else
                {
                    Console.WriteLine("Любое число!");
                }
            }
        }




    }
}
