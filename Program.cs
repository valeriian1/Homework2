using System;
using System.Diagnostics.Metrics;

namespace Homework2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Task 1:\n");
            Product product = new Product("", new Money(0, 0));
            product.InputProduct();
            product.Display();

            Console.WriteLine("Decrease product price:");
            product.InputDecreasePrice();
            product.Display();

            Console.WriteLine("\nTask 2:\n");
            Instrument[] instruments = {
            new Violin(),
            new Trombone(),
            new Ukulele(),
            new Violoncello()
            };

            foreach (Instrument instrument in instruments)
            {
                instrument.ShowName();
                instrument.PlaySound();
                instrument.ShowDesc();
                instrument.ShowHistory();
            }

            Console.WriteLine("\nTask 3:\n");
            DecimalNumber decimalNumber = new DecimalNumber();
            decimalNumber.num = decimalNumber.InputNum();

            Console.WriteLine($"Binary: {decimalNumber.ToBinary()}");
            Console.WriteLine($"Octal: {decimalNumber.ToOctal()}");
            Console.WriteLine($"Hexadecimal: {decimalNumber.ToHexadecimal()}");
        }
    }
}
