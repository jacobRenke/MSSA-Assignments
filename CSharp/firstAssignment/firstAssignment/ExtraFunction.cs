using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstAssignment
{
    public class ExtraFunction
    {
        public void extraGameSelector()
        {
            Console.WriteLine("Press 1 for Random Number Guessing Game: \nPress 2 for Prime Number Game: \nPress 3 for Factorial Game: \nPress 4 for the Season Teller Game: \nPress 5 for Rock, Paper, Scissor: ");
            int option2 = int.Parse(Console.ReadLine());
            switch (option2)
            {
                case 1:
                    Random rnd = new Random();
                    Console.WriteLine("You have selected the Random Number of Stonkz Game. Please press enter to continue: ");
                    Console.ReadKey();
                    int randomNumber = rnd.Next(1, 100);

                    Console.WriteLine("You will have 3 guesses to find the number. Enter a number and good luck!");
                    for (int i = 0; i < 3; i++)
                    {
                        int guess = Convert.ToInt32(Console.ReadLine());
                        if (guess == randomNumber && i < 3)
                        {
                            Console.WriteLine("You win! The number was {0}!", randomNumber);
                        }
                        else if (i == 2)
                        {
                            Console.WriteLine("You are out of attempts.");
                        }
                        else
                        {
                            Console.WriteLine("Try again!");
                        }

                    }
                    break;
                case 2:
                    Console.WriteLine("You have selected the Prime Number game. The computer will tell you if the number you select is a prime number.");
                    int userNum;
                    Console.WriteLine("Please enter a number to check: ");
                    userNum = Convert.ToInt32(Console.ReadLine());

                    if (checkPrime(userNum))
                    {
                        Console.WriteLine("The number is Prime.");
                    }
                    else
                    {
                        Console.WriteLine("The number is not Prime.");
                    }
                    break;

                case 3:
                    try
                    {
                        Console.WriteLine("Entr # ");
                        float fact = float.Parse(Console.ReadLine());
                        float number = fact;
                        for (float n = 1; n < number; n++) fact = fact * n;
                        Console.WriteLine("The fctril of {0} ~ {1}", number, fact);
                    }
                    catch (FormatException exception)
                    {
                        Console.WriteLine(exception);
                        System.Diagnostics.Trace.WriteLine(exception);
                        Console.WriteLine("Sorry. User error. Please try again!");
                    }
                    catch (Exception excpt)
                    {
                        System.Diagnostics.Trace.WriteLine(excpt);
                        Console.WriteLine("You broke it. Try again.");
                    }
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("Please enter your birthday in the following format - YYYY/MM/DD: ");
                        string birthdayInput = Console.ReadLine();
                        DateTime birthdayParse = DateTime.Parse(birthdayInput);
                        int month = birthdayParse.Month;
                        int day = birthdayParse.Day;
                        switch (month)
                        {
                            case 1:
                                if (day >= 1 && day <= 31)
                                {
                                    Console.WriteLine("Your birthday is in the Winter.");
                                }
                                break;
                            case 2:
                                if (day >= 1 && day <= 29)
                                {
                                    Console.WriteLine("Your birthday is in the Winter.");
                                }
                                break;
                            case 3:
                                if (day >= 1 && day <= 19)
                                {
                                    Console.WriteLine("Your birthday is in the Winter.");
                                }
                                else if (day >= 20 && day <= 31)
                                {
                                    Console.WriteLine("Your birthday is in the Spring.");
                                }
                                break;
                            case 4:
                                if (day >= 1 && day <= 30)
                                {
                                    Console.WriteLine("Your birthday is in the Spring.");
                                }
                                break;
                            case 5:
                                if (day >= 1 && day <= 31)
                                {
                                    Console.WriteLine("Your birthday is in the Spring.");
                                }
                                break;
                            case 6:
                                if (day >= 1 && day <= 21)
                                {
                                    Console.WriteLine("Your birthday is in the Spring.");
                                }
                                else if (day >= 22 && day <= 30)
                                {
                                    Console.WriteLine("Your birthday is in the Summer.");
                                }
                                break;
                            case 7:
                                if (day >= 1 && day <= 31)
                                {
                                    Console.WriteLine("Your birthday is in the Summer.");
                                }
                                break;
                            case 8:
                                if (day >= 1 && day <= 31)
                                {
                                    Console.WriteLine("Your birthday is in the Summer.");
                                }
                                break;
                            case 9:
                                if (day >= 1 && day <= 23)
                                {
                                    Console.WriteLine("Your birthday is in the Summer.");
                                }
                                else if (day >= 24 && day <= 30)
                                {
                                    Console.WriteLine("Your birthday is in the Fall.");
                                }
                                break;
                            case 10:
                                if (day >= 1 && day <= 31)
                                {
                                    Console.WriteLine("Your birthday is in the Fall.");
                                }
                                break;
                            case 11:
                                if (day >= 1 && day <= 30)
                                {
                                    Console.WriteLine("Your birthday is in the Fall.");
                                }
                                break;
                            case 12:
                                if (day >= 1 && day <= 21)
                                {
                                    Console.WriteLine("Your birthday is in the Fall.");
                                }
                                else if (day >= 22 && day <= 31)
                                {
                                    Console.WriteLine("Your birthday is in the Winter.");
                                }
                                break;

                        }
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                    }
                    break;
                case 5:
                    int rock = 1;
                    int paper = 2;
                    int scissors = 3;
                    int userNumm = 0;        //user's choice of Rock Paper or Scissors          
                    int computerNum = 0;    //computer's choice of Rock Paper or Scissors               
                    Random randomNum1 = new Random();
                    try
                    {
                        do
                        {
                            Console.WriteLine("Enter 1 for Rock, 2 for Paper, or 3 for Scissors");
                            userNumm = Int32.Parse(Console.ReadLine());
                        } while (userNumm != 1 && userNumm != 2 && userNumm != 3);  ///if the user enters a number other than 1, 2, or 3
                        computerNum = randomNum1.Next(1, 3);    //using random number generator 1-3

                        if (userNumm == computerNum)
                        {
                            Console.WriteLine("Tie!!");
                        }
                        else if (userNumm == rock && computerNum == scissors || userNumm == paper && computerNum == rock || userNumm == scissors && computerNum == paper)
                        {
                            Console.WriteLine("You Win!!");
                        }
                        else
                        {
                            Console.WriteLine("You Loose!!");
                        }

                        switch (computerNum)
                        {
                            case 1:
                                Console.WriteLine("The computer chose rock");
                                break;
                            case 2:
                                Console.WriteLine("The computer chose paper");
                                break;
                            case 3:
                                Console.WriteLine("The computer chose scissors");
                                break;
                            default:
                                break;
                        }
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                    };
                    break;
          
            }
            static bool checkPrime(int num)
            {
                for (int x = 2; x < num; x++)
                    if (num % x == 0)
                        return false;
                return true;
            }
        }
    }
}
