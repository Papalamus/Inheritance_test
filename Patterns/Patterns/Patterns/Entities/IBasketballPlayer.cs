using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Factory;

namespace Patterns.Entities
{
    interface IBasketballPlayer
    {
        void Throw();
        void Pass();
        void Guard();
        PlayerFactory GetFactory();
    }
}
