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
    public class GuessController : IGuessController
    {
        public List<Guess> GetAllGuess(string[] guess)
        {
            return guess.Select(g => new Guess()
            {
                GuessCoordinate =
            new Point(
                int.Parse(g.Split(':')[0]),
                int.Parse(g.Split(':')[1]))
            }).ToList();
        }
    }

    public class GuessComparer : IEqualityComparer<Guess>
    {
        public bool Equals(Guess x, Guess y)
        {
            return x.GuessCoordinate.X == y.GuessCoordinate.X && x.GuessCoordinate.Y == y.GuessCoordinate.Y;
        }

        public int GetHashCode(Guess obj)
        {
            return obj.GuessCoordinate.GetHashCode();
        }
    }
}
