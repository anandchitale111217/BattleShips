using Battleships.Contract;
using Battleships.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Battleships.Test
{
    public class ShipControllerTest
    {
        [Theory]
        [InlineData(new string[] { "3:2,3:5" },1, 3, 2,3,5)]
        [InlineData(new string[] { "7:2,7:9" }, 1, 7, 2, 7, 9)]
        public void GetAllShipsTest(string[] input,int shipcount, int startx,int starty,int endx,int endy)
        {
            //Unit test to prove the task.
            IShipController shipController = new ShipController();
            var ships = shipController.GetAllShips(input);

            Assert.Equal(shipcount, ships.Count);

            Assert.Equal(startx, ships.First().StartCoordinate.Point.X);
            Assert.Equal(starty, ships.First().StartCoordinate.Point.Y);
            Assert.Equal(endx, ships.First().EndCoordinate.Point.X);
            Assert.Equal(endy, ships.First().EndCoordinate.Point.Y);

        }
    }
}
