using Battleships.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.Controller
{
    public class GameController : IGameController
    {
        string[] _ships;
        string[] _guesses;
        public GameController(string[] ships,string[] guess)
        {
            _ships = ships;
            _guesses = guess;

        }
        public int Playgame(IShipController shipController, IGuessController guessController)
        {
            var ships = shipController.GetAllShips(_ships);

            var guesses = guessController.GetAllGuess(_guesses);

            foreach(var sh in ships)
            {
                sh.SetShipPoints();
                var shipPoints = sh.Shippoints;
                foreach(var guess in  guesses)
                {
                    var seeifhit = shipPoints.FirstOrDefault(item => item.Point.X == 
                    guess.GuessCoordinate.X && item.Point.Y == guess.GuessCoordinate.Y);

                    if(seeifhit != null)
                    {
                        seeifhit.IsHit = true;
                    }
                }
            }

            return ships.Count(item => item.IsSinking);
        }
    }
}
