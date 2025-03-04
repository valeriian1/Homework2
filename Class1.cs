using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Money
    {
        private int wholePart;
        private int cents;

        public Money(int wholePart, int cents)
        {
            SetMoney(wholePart, cents);
        }

        public void SetMoney(int wholePart, int cents)
        {
            if (wholePart < 0 || cents < 0)
            {
                throw new ArgumentException("You have entered a negative value.");
            }

            this.wholePart = wholePart + cents / 100;
            this.cents = cents % 100;
        }

        public void ShowMoney()
        {
            Console.WriteLine($"Price: {wholePart}.{cents:D2}");
        }

        public void Decrease(int wholePart, int cents)
        {
            int totalCents = this.wholePart * 100 + this.cents;
            int decreaseCents = wholePart * 100 + cents;

            if (decreaseCents > totalCents)
            {
                throw new ArgumentException("Error: decrease value exceeds total amount.");
            }

            totalCents -= decreaseCents;
            this.wholePart = totalCents / 100;
            this.cents = totalCents % 100;
        }

        public void InputMoney()
        {
            int whole, cent;
            Console.Write("Enter whole part: ");
            while (!int.TryParse(Console.ReadLine(), out whole) || whole < 0)
            {
                Console.Write("Invalid input. Enter a non-negative whole part: ");
            }

            Console.Write("Enter cents: ");
            while (!int.TryParse(Console.ReadLine(), out cent) || cent < 0 || cent >= 100)
            {
                Console.Write("Invalid input. Enter cents: ");
            }

            SetMoney(whole, cent);
        }
    }

    class Product
    {
        private string name;
        private Money price;

        public Product(string name, Money price)
        {
            this.name = name;
            this.price = price;
        }

        public void InputProduct()
        {
            Console.Write("Enter product name: ");
            name = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Enter price:");
            price.InputMoney();
        }

        public void Display()
        {
            Console.WriteLine($"Товар: {name}");
            Console.Write("Price: ");
            price.ShowMoney();
        }

        public void InputDecreasePrice()
        {
            Console.WriteLine("Enter amount to decrease price:");
            int whole, cents;

            Console.Write("Enter whole part: ");
            while (!int.TryParse(Console.ReadLine(), out whole) || whole < 0)
            {
                Console.Write("Invalid input. Enter a non-negative whole part: ");
            }

            Console.Write("Enter cents: ");
            while (!int.TryParse(Console.ReadLine(), out cents) || cents < 0 || cents >= 100)
            {
                Console.Write("Invalid input. Enter cents: ");
            }

            price.Decrease(whole, cents);
        }
    }
}
