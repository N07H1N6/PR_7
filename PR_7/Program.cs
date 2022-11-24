//************************************************************************
//*Практическая работа № 7                                             *
//* Выполнил:Кондаков.П.А,Группа 2ИСП                                    *
//*Задание:Составление программ циклической структуры: цикл с параметром.*
//************************************************************************

using System;

namespace PR_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, h, F, x;
            Console.WriteLine("Здравствуйте");
            Console.WriteLine("Введите значения");
            Console.WriteLine("a= ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b= ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("h= ");
            h = Convert.ToDouble(Console.ReadLine());
            for (x = a; x <= b; x = x + h)
            {
                Console.Write($"F = {x}");

                Console.Write($"\nЗначение функции при  F={x}\t" + Math.Tan(x / 2) + (2 * Math.Cos(x)));
            }
            Console.ReadKey();
        }

    }
}
            
            

            








        