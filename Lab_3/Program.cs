using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RomanNumber n1 = new RomanNumber(15); RomanNumber n2 = new RomanNumber(42); RomanNumber n3 = new RomanNumber(3);RomanNumber n4 = new RomanNumber(11); RomanNumber n5 = new RomanNumber(21);
                Console.WriteLine($"{n1.ToString()} + {n5.ToString()} = {(n1 + n5).ToString()}");
                Console.WriteLine($"{n2.ToString()} / {n3.ToString()} = {(n2 / n3).ToString()}");
                Console.WriteLine($"{n5.ToString()} - {n4.ToString()} = {(n5 - n4).ToString()}");
                Console.WriteLine($"{n1.ToString()} * {n3.ToString()} = {(n1 * n3).ToString()}");

                RomanNumber[] items = { n1, n2, n3, n4, n5 };
                Array.Sort(items);
                Console.WriteLine("\nSorted: \n");
                foreach (var number in items)
                {
                    Console.WriteLine($"{number.ToString()} \n");
                }

            }
            catch (RomanNumberException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

        }
    }
}