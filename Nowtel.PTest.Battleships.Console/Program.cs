using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nowtel.PTest.Battleships.Logic;

namespace Nowtel.PTest.Battleships
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var randomBoardFactory = new RandomBoardFactory();
            var consoleInterface = new ConsoleInterface();
            var game = new GameProcessor(randomBoardFactory, consoleInterface);
            game.Play();
            Environment.Exit(0);
        }
    }
}
