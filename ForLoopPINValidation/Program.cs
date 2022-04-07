using System;

namespace ForLoopPINValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter PIN");
                string userPIN = Console.ReadLine();

                if(userPIN == "1234")
                {
                    Console.WriteLine("welcome");
                    break;
                }
                else
                {
                    Console.WriteLine($"You tried to log in {i+1}/3 times.");
                    if(i == 2)
                    {
                        Console.WriteLine("No attempts left. try again later.");
                    }
                }
            }
        }
    }
}
