using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nowtel.PTest.Battleships.Model
{
    public class Destroyer : Ship
    {
        public Destroyer(ShipDirection direction) : base(direction) { }

        public override int Length
        {
            get
            {
                return 4;
            }
        }
    }
}
