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
            try
            {
                double a, b, h, F, x;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Здравствуйте");
                Console.WriteLine("Введите значения");
                Console.Write("a= ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b= ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("h= ");
                h = Convert.ToDouble(Console.ReadLine());

                for (x = a; x <= b; x = x + h)
                {
                    Console.Write($"F = {x}");

                    Console.Write($"\nЗначение функции при  F={x}\t" + Math.Tan(x / 2) + (2 * Math.Cos(x)));
                    Console.Write(" ");
                }
            }
            catch(DivideByZeroException e)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Пользователь ввел ноль:" + e.Message);
            }
            catch (Exception fe)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка:" + fe.Message);
            }
            Console.ReadKey();
        }

    }
}
            
            

            








        