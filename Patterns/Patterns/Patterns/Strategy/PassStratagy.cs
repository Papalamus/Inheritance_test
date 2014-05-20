using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    class PassStratagy:GameStrategy
    {
        public override void AttackPlan()
        {

            Console.WriteLine("Lot of Passes ");
            foreach (var player in Players.TeamPlayers)
            {
                player.Pass();
            }
            Players.TeamPlayers[0].Throw();
        }

        public override void DefendPlan()
        {
            Console.WriteLine("Only couple players defend ");
            Players.TeamPlayers[4].Guard();
            Players.TeamPlayers[5].Guard();
        }
    }
}
