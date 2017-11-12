using Nowtel.PTest.Battleships.Logic;
using System;

namespace Nowtel.PTest.Battleships
{
    public class ConsoleInterface
        : IUserInterface
    {
        public string GetUserInput()
        {
            var input = Console.ReadLine();
            return input;
        }

        public void RenderMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
