using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.Contract
{
    public interface IGameController
    {
        int Playgame(IShipController shipController,IGuessController guessController);
    }
}
