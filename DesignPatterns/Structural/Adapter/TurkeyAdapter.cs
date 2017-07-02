using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class TurkeyAdapter : IDuck
    {
        private ITurkey _turkey;
        
        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }

        public string Fly()
        {
            return _turkey.Fly();
        }

        public string Quack()
        {
            return _turkey.Gobble();
        }
    }
}
