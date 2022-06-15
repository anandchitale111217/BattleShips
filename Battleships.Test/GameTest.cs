using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Battleships;
using FluentAssertions;
using Xunit;

namespace Battleships.Test
{
    public class GameTest
    {
        [Theory]
        [InlineData(new[] { "3:2,3:5" }, new[] { "7:0", "3:3" },0)]
        [InlineData(new[] { "3:2,3:5" }, new[] { "3:2", "3:3","3:4","3:5" }, 1)]
        [InlineData(new[] { "3:2,3:5", "3:6,3:8" }, new[] { "3:2", "3:3", "3:4", "3:5" , "3:6" , "3:7" , "3:8" }, 2)]
        [InlineData(new[] { "3:2,3:5", "3:6,3:8" }, new[] { "3:2", "3:3", "3:4", "3:5", "3:6", "3:7", "3:9" }, 1)]
        public void TestPlay(string[] tstships,string[] tstguesses , int sunkshipcount)
        {
            //Unit test to prove the task.
            var ships = tstships;
            var guesses = tstguesses;
            Game.Play(ships, guesses).Should().Be(sunkshipcount);
        }
    }
}
