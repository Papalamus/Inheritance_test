using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    class Spectator
    {
        public void Run(string destination)
        {
            Console.WriteLine("Spectator run to " + destination);
        }
        public void ThrowBall(string goal)
        {
            Console.WriteLine("Spectator throw ball towards" + goal);
        }
    }
}
