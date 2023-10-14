using System;

namespace NumberGuessingGame 
{
    class NumberGuessingGame
    {
        public static void Main(string[] args)
        {
            /*
             * -generate random number between set minimum and maximum
             * -let the user guess what the number is
             * -give a hint if the guess number is too high or too low
             * -user can keep on guessing until he gets the right answer
             * -keep track of how many attempts it takes
             */

            //give information and instructions about the program
            Console.WriteLine("Number Guessing Name\n");
            Console.WriteLine("Instructions: Enter a minimum and maximum number from where you will guess.\n When guessing the number, " +
                "If you fail to enter the correct number,\n" +
                "The program will give hints on whether the number you guessed is too high or too low from the generated random number. " +
                "You can guess until you get the right answer.\n" +
                "At the end of the program, \nyou can view how many times you took a guess before guessing the right number.\n");
            
            //ask the user to input the minimum and maximum
            Console.Write("Enter minimum number: ");
            int minimum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a maximum number: ");
            int maximum = Convert.ToInt32(Console.ReadLine());

            //create a new random object to be used in generating a random number
            Random random = new Random();
            int num = random.Next(minimum, maximum); //generate a random number between the value of minimum and maximum then assign it to variable num

            //ask the user to input their guess
            Console.Write("\nGuess the number between " + minimum + " and " + maximum + ": ");
            int guess = Convert.ToInt32(Console.ReadLine());

            //set a counter variable to keep track how many attempts is made
            int counter = 1;

            //set a loop that runs until the user guessed the right number
            while (guess != num)
            {
                //if the guess is higher than the random generated number, print that the guess is too high and ask the user again to guess
                if (guess > num)
                {
                    Console.WriteLine("Your guess is too high");
                    Console.Write("Guess the number between " + minimum + " and " + maximum + ": ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }

                //if the guess is lower than the random generated number, print that the guess is too low and ask the user again to guess
                else if (guess < num)
                {
                    Console.WriteLine("Your guess is too low");
                    Console.Write("Guess the number between " + minimum + " and " + maximum + ": ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                counter++; //increment counter variable each attempt
            }
            Console.WriteLine("\nCongratulations! You guessed it right! The correct number is: " + num +
                "\nIt took you " + counter + " times!");
            Console.ReadKey();
        }
    }
}