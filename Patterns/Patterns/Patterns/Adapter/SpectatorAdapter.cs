using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Entities;
using Patterns.Factory;

namespace Patterns.Adapter
{
    class SpectatorAdapter:IBasketballPlayer
    {
        public SpectatorAdapter(Spectator sp)
        {
            _sp = sp;
        }

        private Spectator _sp;
        
        public void Throw()
        {
            _sp.Run("Basket");
            _sp.ThrowBall("Basket");
        }

        public void Pass()
        {
            _sp.ThrowBall("Player");
        }

        public void Guard()
        {
            _sp.Run("Enemy player");
        }

        public Factory.PlayerFactory GetFactory()
        {
            return new SpectatorAdapterFactory();
        }

        private class SpectatorAdapterFactory : PlayerFactory
        {

            public IBasketballPlayer GetPlayer()
            {
                return new SpectatorAdapter(new Spectator());
            }
        }
    }
}
