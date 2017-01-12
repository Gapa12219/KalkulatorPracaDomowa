using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    abstract class Działania : GłówneDziałania
    {
        public double x;
        public double y;
        public double wynik;
        
        public abstract void Działanie();
       
    }
}
