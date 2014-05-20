using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    class DefendStrategy:GameStrategy
    {
        public override void AttackPlan()
        {
            Console.WriteLine(" Атакует только парочка");
            Players.TeamPlayers[0].Pass();
            Players.TeamPlayers[1].Throw();
        }

        public override void DefendPlan()
        {
            Console.WriteLine("А Защищаются все");
            foreach (var basketballPlayer in Players.TeamPlayers)
            {
                basketballPlayer.Guard();
            }
        }
    }
}
