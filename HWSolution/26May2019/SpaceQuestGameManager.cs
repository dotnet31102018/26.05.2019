using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26May2019
{
    class SpaceQuestGameManager
    {
        private int _goodSpaceShipHitPoint = 0;
        private int _shipXLocation = 0;
        private int _shipYLocation = 0;
        private int _numberOfBadShips = 0;
        private int _currentLevel = 1;

        public event EventHandler<LocationEventArgs> GoodSpaceShipLocationChanged;

        public event EventHandler<PointEventArgs> GoodSpaceShipHPChanged;

        public SpaceQuestGameManager(int goodSpaceShipHitPoint, int shipXLocation, int shipYLocation, int numberOfBadShips)
        {
            _goodSpaceShipHitPoint = goodSpaceShipHitPoint;
            _shipXLocation = shipXLocation;
            _shipYLocation = shipYLocation;
            _numberOfBadShips = numberOfBadShips;
        }

        private void OnGoodSpaceShipLocationChanged()
        {
            if (GoodSpaceShipLocationChanged != null)
            {
                //LocationEventArgs locationEventArgs = new LocationEventArgs();
                //locationEventArgs.X = _shipXLocation;
                //locationEventArgs.Y = _shipYLocation;
                GoodSpaceShipLocationChanged.Invoke(this, new LocationEventArgs { X = _shipXLocation, Y = _shipYLocation });
            }
        }

        private void OnGoodSpaceShipHPChanged()
        {
            if (GoodSpaceShipHPChanged != null)
            {
                GoodSpaceShipHPChanged.Invoke(this, new PointEventArgs { HitPoint = _goodSpaceShipHitPoint });
            }
        }

        public void MoveSpaceShip(int newX, int newY)
        {
            _shipXLocation = newX;
            _shipYLocation = newY;
            OnGoodSpaceShipLocationChanged();
        }

        public void GoodSpaceShipGotExtraHP(int extra)
        {
            _goodSpaceShipHitPoint += extra;
            OnGoodSpaceShipHPChanged();
        }

        public void GoodSpaceShipGotDamaged(int damage)
        {
            _goodSpaceShipHitPoint -= damage;
            OnGoodSpaceShipHPChanged();
        }
    }
}
