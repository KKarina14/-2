using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //тут пишем код
            Console.WriteLine("Hello world!");  //пишем в консоль
            Console.WriteLine(" Мороз и солнце; день чудесный!");

            string name = "Карина";

            Console.WriteLine($"Меня зовут {name} "); // внутри поля 

            Console.Write($"Введите ваше хобби: ");
            string hobby = Console.ReadLine(); //ввод данных
            Console.WriteLine($"Ваше хобби: {hobby} ");

            Console.Write("Сколько вам лет: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вам {age} лет");

            Console.WriteLine($"Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Сумма чисел: {a} + {b} = {a + b}");

            Console.WriteLine($"умножение чисел: {a} * {b} = {a * b}");

            Console.WriteLine($"разность чисел: {a} - {b} = {a - b}");

            Console.WriteLine($"деление чисел: {a} / {b} = {a / b}");

            Console.ReadKey(); //пауза
        }
    }
}

