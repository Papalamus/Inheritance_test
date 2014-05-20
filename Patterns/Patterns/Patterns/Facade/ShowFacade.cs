using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Adapter;

namespace Patterns.Facade
{
    class ShowFacade
    {
        private Trainer _trainer;
        private SpectatorAdapter _spec;
        private CheerLeaders _cheerLeaders;

        public ShowFacade()
        {
            _trainer = new Trainer();
            _cheerLeaders = new CheerLeaders();
        }

        public void AskRotate()
        {
            _trainer.RotatePlayers();
        }

        public void Timeout()
        {
            _trainer.TakeTimeout();
            
            _cheerLeaders.Dance();
        }

        public void Period()
        {
            _cheerLeaders.Dance();
            _spec = new SpectatorAdapter(new Spectator());
            _spec.Throw();
        }
    }
}
