using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26May2019
{
    class Program
    {

        private static Random random = new Random();

        private static SpaceQuestGameManager game;
        private static void ElapsedEventHandler(object sender, System.Timers.ElapsedEventArgs e)
        {
            game.MoveSpaceShip(random.Next(1000), random.Next(1000));
        }

        private static void DisposedEventHandler(object sender, EventArgs e)
        {

        }

        static void Main(string[] args)
        {
            game = new SpaceQuestGameManager(100, 5, 5, 10);
            GameViewer viewer = new GameViewer();

            game.GoodSpaceShipLocationChanged += viewer.GoodSpaceShipLocationChangedEventHandler;

            game.MoveSpaceShip(10, 15);

            System.Timers.Timer t = new System.Timers.Timer();
            t.Interval = 1000;
            //t.Disposed += DisposedEventHandler;
            t.Elapsed += ElapsedEventHandler;
            t.Start();

            while(true)
            {

            }

        }
    }
}
