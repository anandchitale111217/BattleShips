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
    public class GuessControllertest
    {
        [Theory]
        [InlineData(new string[] { "3:2" }, 1, 3, 2)]
        [InlineData(new string[] { "7:2" , "3:2" }, 2, 7, 2)]
        [InlineData(new string[] { "7:2", "3:2","3:5","3:5" }, 4, 7, 2)]
        public void GetAllGuessTest(string[] input, int shipcount, int startx, int starty)
        {
            //Unit test to prove the task.
            IGuessController Controller = new GuessController();
            var gueses = Controller.GetAllGuess(input);

            Assert.Equal(shipcount, gueses.Count);

            Assert.Equal(startx, gueses.First().GuessCoordinate.X);
            Assert.Equal(starty, gueses.First().GuessCoordinate.Y);
            

        }
    }
}
