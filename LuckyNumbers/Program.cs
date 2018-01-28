using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART ONE
            // ask user for starting number, ask for ending number (set as lowest, highest number in range), 
            //ask user to input 6 numbers  
            //Must validate numbers from user input, must prompt user for valid numbers


            string play = " ";
            int jackpot = 7654321;
            do
            {
                Console.WriteLine("Welcome to the Lucky Numbers Game! \n \nThe jackpot is now at $7,654,321, match all six numbers to win!\n");
                Console.WriteLine("Please choose a starting number");
                int startNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Please choose an ending number");
                int endNumber = int.Parse(Console.ReadLine());
                Console.WriteLine();


                //loop and array
                // check validity of the entered numbers, no rpeating inputs (bool?)


                //Lucky number useer input 
                int[] luckyNum = new int[6]; //length of six


                for (int i = 0; i < luckyNum.Length; i++) //NO SEMI COLON!!!!!!!!!!!!!
                                                          // while luckyNum < startNum, while LuckyNum > endNum
                {
                    Console.WriteLine("Please enter a lucky number");
                    luckyNum[i] = int.Parse(Console.ReadLine());
                    if (luckyNum[i] < startNumber || luckyNum[i] > endNumber)
                    {
                        Console.WriteLine("Please enter a valid number between the start and end number");
                        luckyNum[i] = int.Parse(Console.ReadLine());
                    }

                    //for (int t = 0; t < luckyNum.Length; i++)
                    //{
                    //    Console.WriteLine("Please enter a lucky number");
                    //    luckyNum[i] = int.Parse(Console.ReadLine());
                    //    if (luckyNum[i] < startNumber || luckyNum[i] > endNumber)
                    //    {
                    //        Console.WriteLine("Please enter a valid number between the start and end number");
                    //        luckyNum[i] = int.Parse(Console.ReadLine());
                    //    }
                    // }
                }


                // Random Number generator, must use start and end numbers from the user input
                // must display randoms using a loop

                Random r = new Random();

                int[] rArray = new int[6];

                for (int i = 0; i < rArray.Length; i++)
                {
                    rArray[i] = r.Next(startNumber, endNumber);
                    Console.WriteLine("Lucky Number: " + rArray[i]);
                }

                // calculate the number of matches

                bool matches = false;
                int count = 0;

                for (int i = 0; i < luckyNum.Length; i++)
                {
                    for (int j = 0; j < rArray.Length; j++)
                    {
                        if (luckyNum[i] == rArray[j])
                        {
                            matches = true;
                            count++;

                        }

                    }

                }

                Console.WriteLine("You have matched " + count + " lucky numbers \n");

                // calculate winnings based on the number of matches

                if (count == 0)
                {
                    Console.WriteLine("You Lose!");
                }

                if (count == 1)
                {
                    Console.WriteLine("You win " + jackpot / 6 + "!");
                }

                if (count == 2)
                {
                    Console.WriteLine("You win " + jackpot / 5 + "!");
                }

                if (count == 3)
                {
                    Console.WriteLine("You win " + jackpot / 4 + "!");
                }

                if (count == 4)
                {
                    Console.WriteLine("You win " + jackpot / 3 + "!");
                }

                if (count == 5)
                {
                    Console.WriteLine("You win " + jackpot / 2 + "!");
                }

                if (count == 6)
                {
                    Console.WriteLine("You win " + jackpot + "!");
                }

                // part two, play again, exit.
                Console.WriteLine("Would you like to play again? Type exit to quit.");
                play = Console.ReadLine();

            } while (play != "exit");
            if (play == "exit")
            {
                Console.WriteLine("Thanks for playing!");
            }



        }

    }
}
