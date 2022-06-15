using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.Model
{
    public class Ship
    {
        public Shippoint StartCoordinate { get; set; }

        public Shippoint EndCoordinate { get; set; }

        public List<Shippoint> Shippoints { get; set; }

        public bool IsSinking => Shippoints.All(item => item.IsHit);

        public void SetShipPoints()

        {
            List<Shippoint> shipPoints = new List<Shippoint>();
            //Horizontal Ship
            if (StartCoordinate.Point.X == EndCoordinate.Point.X)
            {
                int starty = StartCoordinate.Point.Y;
                while (starty <= EndCoordinate.Point.Y)
                {
                    shipPoints.Add(new Shippoint(StartCoordinate.Point.X, starty));
                    starty++;
                }

            }
            else if(StartCoordinate.Point.Y == EndCoordinate.Point.Y)
            {
                int startx = StartCoordinate.Point.X;
                while (startx <= EndCoordinate.Point.X)
                {
                    shipPoints.Add(new Shippoint(startx, StartCoordinate.Point.Y));
                    startx++;
                }
            }
            Shippoints = shipPoints;
        }
    }
}
