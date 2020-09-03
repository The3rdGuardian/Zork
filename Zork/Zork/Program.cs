using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            string outputString;
            Commands command = Commands.UNKNOWN;
            while (command != Commands.QUIT)
            {
                Console.Write("> ");
                command = ToCommand(Console.ReadLine().Trim());

                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing.";
                        break;

                    case Commands.LOOK:
                        outputString = "This is an open field west of a white house, with a boarded front door. A rubber mat saying 'Welcome to Zork!' lies by the door.";
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:

                        outputString = $"you moved {command}";
                        break;

                    default:
                        outputString = "Unknown Command";
                        break;
                }

                Console.WriteLine(outputString);
            }
            
        }

        static Commands ToCommand(string inputString) => Enum.TryParse(inputString, true, out Commands result) ? result : Commands.UNKNOWN;

    }
}
