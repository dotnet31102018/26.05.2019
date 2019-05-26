using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26May2019
{
    class GameViewer
    {
        public void GoodSpaceShipLocationChangedEventHandler (object sender, LocationEventArgs e)
        {
            Console.WriteLine($"GameViewer is drawing the ship after movement to new location X:{e.X} Y:{e.Y}");
        }
    }
}
