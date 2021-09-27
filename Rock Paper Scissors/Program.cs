using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string playAgain = " ";
            do
            {
                TheGame();
                Console.WriteLine("Enter \"P\" to play again or any other key to quit");
                playAgain = Console.ReadLine().ToUpper();
            } while (playAgain == "P");
            
            // the Rock Paper and scossors method
            static void TheGame()
            {
                Random random = new Random();
                int botChoice = random.Next(1, 3);
                int userChoice = 0;
                bool notCorrect = true;
               // While the user does not choose the right case will continue.
                while (notCorrect)
            {
                    try
                    {
                        Console.Write("\nSelect from 1 - 3 Rock (1), Paper (2), Scissors(3) : ");
                        userChoice = int.Parse(Console.ReadLine());
                        switch (userChoice)
                        {
                            case 1:
                                Console.WriteLine("Rock");
                                notCorrect = false;
                                break;
                            case 2:
                                Console.WriteLine("Paper");
                                notCorrect = false;
                                break;
                            case 3:
                                Console.WriteLine("Scissors");
                                notCorrect = false;
                                break;
                            default:
                                Console.WriteLine("You picked the wrong tool");
                                break;
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message + "You picked the wrong tool");
                    }
                }
                // To get the AI choice
                switch (botChoice)
                {
                    case 1:
                        Console.WriteLine("Bot chose Rock");
                        break;
                    case 2:
                        Console.WriteLine("Bot chose Paper");
                        break;
                    case 3:
                        Console.WriteLine("Bot chose Scissors");
                        break;
                    default:
                        break;
                }
                //Determine the winner
                    if (userChoice == 1 && botChoice == 3)
                    {
                        Console.WriteLine("You smash the Scissors \nYou Win!");
                    }
                    else if (botChoice == 1 && userChoice == 3)
                    {
                        Console.WriteLine("Bot smashes your Scissors \nYou Lose!");
                    }
                    else if (userChoice == 3 && botChoice == 2)
                    {
                        Console.WriteLine("You cut the Paper \nYou Win!");
                    }
                    else if (botChoice == 3 && userChoice == 2)
                    {
                        Console.WriteLine("Bot cut your Paper \nYou Lose!");
                    }
                    else if (userChoice == 2 && botChoice == 1)
                    {
                        Console.WriteLine("You wrap the Rock \nYou Win!");
                    }
                    else if (botChoice == 2 && userChoice == 1)
                    {
                        Console.WriteLine("Bot wrasp your Rock \nYou Lose!");
                    }
                    else
                    {
                        Console.WriteLine("It's a Tie!");
                    }
            }
            Console.ReadLine();
        }
    }
}
