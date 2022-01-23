using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вычислить факториал числа: ");
            int n = Convert.ToInt32(Console.ReadLine());
            FactorialAsync(n);
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Варим кофе");
                Thread.Sleep(100);
            }
            Console.WriteLine("Закончили варить кофе");
            Console.ReadKey();
        }
        static async void FactorialAsync(int n)
        {
            Console.WriteLine("Начинаем вычисляем факториал:");
            await Task.Run(() =>
            {
                int result = 1;
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Промежуточное вычисление: {result *= i}");
                    Thread.Sleep(100);
                }
                Console.WriteLine($"Факториал вычислен: {result}");
            });

        }
    }
}


