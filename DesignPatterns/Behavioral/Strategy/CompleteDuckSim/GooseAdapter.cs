using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy.CompleteDuckSim
{
    public class GooseAdapter : IQuackable
    {
        private Goose _goose;

        public GooseAdapter(Goose goose)
        {
            _goose = goose;
        }
        public void Quack()
        {
            _goose.Honk();
        }
    }
}
