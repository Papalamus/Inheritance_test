using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    abstract class GameStrategy
    {
        public Team Players { get; set; }

        public abstract void AttackPlan();
        public abstract void DefendPlan();
    }
}
