using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Dice Rolling game!!");
            int sides, die1, die2;
            int rolls = 1;
            bool rollem = true;
            while (rollem)
            {
                Console.WriteLine("How many sides on your dice would you like to have?");
                sides = int.Parse(Console.ReadLine());
                Check(sides);
                die1 = Roll(sides);
                die2 = Roll(sides);
                Check(die1, die2);
                OutputRolls(rolls, die1, die2);
                Console.WriteLine("Would you like to roll again? (y/n)");
                rollem = KeepRolling();
                if (rollem == true)
                {
                    rolls++;
                }
            }
            Console.WriteLine("Take care!");
        }

        public static void Check (int num)
        {
            if (num == 20)
            {
                Console.WriteLine("Nerd.");
            }
        }

        public static void Check (int num1, int num2)
        {
            if (num1 == num2)
            {
                if (num1 == 1)
                {
                    Console.WriteLine("SNAKE EYES!!!");
                }
                else if (num1 == 6)
                {
                    Console.WriteLine("BOX CARS!!!!");
                }
            }else if (num1 + num2 == 7)
            {
                Console.WriteLine("CRAPS!!!");
            }
        }

        public static int Roll (int dieSides)
        {
            Random roll = new Random();
            return roll.Next(1, dieSides);
        }

        public static void OutputRolls(int count, int roll1, int roll2)
        {
            Console.WriteLine($"Roll {count}:");
            Console.WriteLine($"Die 1: {roll1}");
            Console.WriteLine($"Die 2: {roll2}");
        }

        public static bool KeepRolling()
        {
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "y":
                    return true;
                case "n":
                    return false;
                default:
                    Console.WriteLine("I'm sorry, that's a bad input. Please try again!");
                    return KeepRolling();
            }
        }
    }
}
