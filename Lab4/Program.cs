using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("Welcome to the Grand Circus Dice Rolling game!!");

            //Make Variables
            int sides, die1, die2;
            int rolls = 1;
            bool rollem = true;

            //Main Roll
            while (rollem)
            {
                //Collect how many saides the person wants
                Console.WriteLine("How many sides on your dice would you like to have?");
                sides = int.Parse(Console.ReadLine());
                
                //Roll The Dice!
                Check(sides);
                die1 = Roll(sides);
                die2 = Roll(sides);

                //Check Dice Sides for fun messages
                Check(die1, die2);

                //Print output
                OutputRolls(rolls, die1, die2);

                //Ask to go play again
                Console.WriteLine("Would you like to roll again? (y/n)");
                rollem = KeepRolling();

                //Increment the number of rolls, if the user is playing again
                if (rollem == true)
                {
                    rolls++;
                }
            }
            Console.WriteLine("Take care!");
        }

        //Checks to see if we have a DnD player playing
        public static void Check (int num)
        {
            if (num == 20)
            {
                Console.WriteLine("Nerd.");
            }
        }

        //Checks to see if the player got a special roll
        public static void Check (int num1, int num2)
        {
            //Snakes Eyes or Box Cars
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
            //Craps (Guess I missed a few)
            }else if (num1 + num2 == 7)
            {
                Console.WriteLine("CRAPS!!!");
            }
        }

        //Dice rolling method
        public static int Roll (int dieSides)
        {
            //Random to generate a random number
            Random roll = new Random();
            //Returning the random's roll between 1 and the number of sides.
            return roll.Next(1, dieSides);
        }
        //Printing the rolls
        public static void OutputRolls(int count, int roll1, int roll2)
        {
            Console.WriteLine($"Roll {count}:");
            Console.WriteLine($"Die 1: {roll1}");
            Console.WriteLine($"Die 2: {roll2}");
        }
        //Recursive method to see if the person wants to keep playing or not
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
