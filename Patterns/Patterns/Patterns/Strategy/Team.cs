using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Entities;

namespace Patterns.Strategy
{
    class Team
    {
        private IBasketballPlayer[] _teamPlayers = new IBasketballPlayer[5] ;

        public IBasketballPlayer[] TeamPlayers
        {
            get { return _teamPlayers; }
            set { _teamPlayers = value; }
        }

        public Team()
        {
            TeamPlayers[0] = new Forward();
            TeamPlayers[1] = new Forward();
            TeamPlayers[2] = new Central();
            TeamPlayers[3] = new Guard();
            TeamPlayers[4] = new Guard();
        }
    }
}
