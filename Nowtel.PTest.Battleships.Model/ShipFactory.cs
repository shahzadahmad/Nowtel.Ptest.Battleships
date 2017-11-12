using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nowtel.PTest.Battleships.Model
{
    public class ShipFactory
    {
        public Ship Get(string shipType, ShipDirection direction)
        {
            switch (shipType)
            {
                case "Battleship":
                    return new Battleship(direction);
                case "Destroyer":
                    return new Destroyer(direction);
                default:
                    throw new InvalidOperationException("The ship type is invalid");
            }
        }
    }
}
