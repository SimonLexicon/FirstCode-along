using System;
using static System.Console;

namespace FirstCode_along
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            int menu = 0;
            while(running)
            {
                
                WriteLine("Hello World!");
                WriteLine("Go to some menu in my switch 1 - 3");
                WriteLine("Exit: 0");

                menu = GetNumberFromUser();
                // Do not use "goto:"
                // This is the menu of the program and is being controlled by the user input.
                switch(menu)
                {
                    case 0:
                        WriteLine("Do you really want to exit?");
                        if (ReadLine() == "y")
                        {
                            running = false;
                            Environment.Exit(0);
                        }
                        break;
                    case 1:
                        WriteLine("Write all numbers to your number");
                        int userInput = GetNumberFromUser();
                        for (int i = 0; i < userInput; i++)
                        {
                            WriteLine("#{0} {1}", i, userInput);
                        }
                        ReadLine();
                        break;
                    case 2:
                        WriteLine("Not implemented yet");
                        break;
                    case 3:
                        WriteLine("Not implemented yet");
                        break;
                    default:
                        WriteLine("Invalid menu option");
                        break;
                }

            }
            
        }
        
        static int GetNumberFromUser()
        {

            int userInput = 0;
            bool succeeded = false;
            while (!succeeded)
            {
                WriteLine("Write a number");
                succeeded = int.TryParse(ReadLine(), out userInput);
            }
            return userInput;
        }

        /*Everything inside "* *" will be commented out!*/

        // Comment
        //Ctrl + K -> C

        // Uncomment
        //Ctrl + K -> U 

        //Multi cursor
        // Ctrl + Alt -> mouseclick where.

    }
}
