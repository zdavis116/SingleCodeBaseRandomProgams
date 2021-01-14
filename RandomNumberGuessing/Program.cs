using System;

namespace RandomNumberGuessing
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome to the Random Number Guessing Game!");
            Console.WriteLine("1st Step: Set the range for the Random Number to be between");
            Console.WriteLine("2nd Step: Then try and guess the random number between your set range. Enter Q to Quit.");

            Console.Write("Please enter your 2 numbers to set the Range the Random Number will be between: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int winNum = RandNumber(num1, num2);

            bool winGame = false;
            string guess = "";

            do
            {
                if (winNum == -1)
                {
                    Console.WriteLine("\nYour set range had the same values so there was no range to pick a random number between");
                    Console.Write("Please re-enter your 2 numbers to set the Range the Random Number will be between: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    num2 = Convert.ToInt32(Console.ReadLine());
                    winNum = RandNumber(num1, num2);
                }
                else
                {
                    Console.Write("\nEnter your Guess: ");
                    guess = Console.ReadLine();

                    if (guess.Equals("Q"))
                    {
                        winGame = true;
                    }
                    else
                    {
                        int g = int.Parse(guess);

                        if (g > winNum)
                        {
                            Console.WriteLine("Guess was to high. Try again...");
                        }
                        else if (g < winNum)
                        {
                            Console.WriteLine("Guess was to low. Try again...");
                        }
                        else if (g == winNum)
                        {
                            winGame = true;
                        }
                    }
                }
                
                Console.WriteLine();

            } while (winGame != true);

            if (guess.Equals("Q"))
            {
                Console.WriteLine("Thank you for playing. Sorry you couldn't finish the game");
                Console.WriteLine("The random number was: " + winNum);
                Console.WriteLine("Press any key to exit the Program");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("You WON!!!");
                Console.WriteLine("Thank you for playing!");
                Console.WriteLine("Press any key to exit the Program");
                Console.ReadKey(true);
            }
        }
        static int RandNumber (int rNum1, int rNum2)
        {
            Random rand = new Random();
            int rNum = 0;

            if (rNum1 > rNum2)
            {
                rNum = rand.Next(rNum2, rNum1);
            }
            else if (rNum2 > rNum1)
            {
                rNum = rand.Next(rNum1, rNum2);
            }
            else if (rNum1 == rNum2)
            {
                rNum = -1;
            }

            return rNum;
        }
    }
}
