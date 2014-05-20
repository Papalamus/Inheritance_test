using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Factory;

namespace Patterns.Entities
{
    class Guard : IBasketballPlayer
    {
        public void Throw()
        {
            Console.WriteLine("Guard: 3pt shoot");
        }

        public void Pass()
        {
            Console.WriteLine("Guard: Perfect pass");
        }
        

        public Factory.PlayerFactory GetFactory()
        {
            return new GuardFactory(); 
        }

        private class GuardFactory : PlayerFactory
        {
            public IBasketballPlayer GetPlayer()
            {
                return new Guard();
            }
        }


        void IBasketballPlayer.Guard()
        {
            Console.WriteLine("Guard: Just run along");
        }
    }
}
