using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class WildTurkey : ITurkey
    {
        public string Fly()
        {
            return "Flying a short distance";
        }

        public string Gobble()
        {
            return "Gobble gobble gobble!";
        }
    }
}
