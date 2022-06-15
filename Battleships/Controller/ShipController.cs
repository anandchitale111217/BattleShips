using Battleships.Contract;
using Battleships.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.Controller
{
    public class ShipController : IShipController
    {
        public List<Ship> GetAllShips(string[] ships)
        {
            List<Ship> shipList = new List<Ship>();

            foreach (string ship in ships)
            {
                var startcoordinate = ship.Split(',')[0].Split(':');
                var endcoordinate = ship.Split(',')[1].Split(':');

                var startx = int.Parse(startcoordinate[0]);
                var starty = int.Parse(startcoordinate[1]);
                var endx = int.Parse(endcoordinate[0]);
                var endy = int.Parse(endcoordinate[1]);
                shipList.Add(new Ship()
                { StartCoordinate = new Shippoint(startx, starty), EndCoordinate = new Shippoint(endx, endy) });
            }

            return shipList;
        }
    }
}
