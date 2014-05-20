using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Factory;

namespace Patterns.Entities
{
    class Central : IBasketballPlayer
    {
        public Factory.PlayerFactory GetFactory()
        {
            return new CentralFactory();
        }

        private class CentralFactory : PlayerFactory
        {
            public IBasketballPlayer GetPlayer()
            {
                return new Central();
            }
        }

        public void Throw()
        {
            Console.WriteLine("Central player always dank");
        }

        public void Pass()
        {
            Console.WriteLine("Central: pass not well");
        }

        public void Guard()
        {
            Console.WriteLine("Central: Blockshot");
        }
    }
}
