using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Entities;
using Patterns.Strategy;

namespace Patterns.Facade
{
    class Trainer
    {
        public Team Players { get; set; }

        public void RotatePlayers()
        {
            IBasketballPlayer tmp = Players.TeamPlayers[0];
            for (int i = 0; i < 4; i++)
            {
                Players.TeamPlayers[i] = Players.TeamPlayers[i+1];
            }
            Players.TeamPlayers[5] = tmp;
        }

        public void TakeTimeout()
        {
            Console.WriteLine("Таймаут");
        }

        public void ReplacePlayer(IBasketballPlayer incoming, int outcomingNumber)
        {
            Players.TeamPlayers[outcomingNumber] = incoming;
        }

    }
}
