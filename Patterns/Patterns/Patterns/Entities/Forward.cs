using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Factory;

namespace Patterns.Entities
{
    class Forward:IBasketballPlayer
    {
        public void Throw()
        {
            Console.WriteLine("Forward: Close throw");
        }

        public void Pass()
        {
            Console.WriteLine("Forward: Well pass");
        }

        public void Guard()
        {
            Console.WriteLine("Forward: Pick ball");
        }

        public Factory.PlayerFactory GetFactory()
        {
            return new ForwardFactory();
        }

        private class ForwardFactory : PlayerFactory
        {
            public IBasketballPlayer GetPlayer()
            {
                return new Forward();
            }
        }
    }
}
