using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace OddEvenNumbersApp
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            PrintNumbers("Numbers", num);
            PrintNumbers("Even No", num.Where(n => IsEven(n)));
            PrintNumbers("Odd No", num.Where(n => IsOdd(n)));

            Console.ReadLine();


        }
        static void PrintNumbers(string titel, IEnumerable<int> numbers)
        {
            Console.Write($"{titel} : [");
            foreach (var num in numbers)
            {
                Console.Write(num + ",");
            }
            Console.WriteLine("]");
        }

        static bool IsEven(int Number) => Number % 2 == 0;

        static bool IsOdd(int Number) => !IsEven(Number);

    }
        
}

