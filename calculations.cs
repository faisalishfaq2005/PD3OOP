using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.BL
{
    internal class calculations
    {
        public calculations() { }
        public calculations(double val1, double val2)
        {
            value1 = val1;
            value2 = val2;

        }
        public calculations(calculations c)
        {
            value1=c.value1;
            value2=c.value2;
        }
        
        
        
        public double value1;
        public double value2;   

        public double addition()
        {
            return value1 + value2;

        }
        public double subtraction()
        {
            return value1 - value2;

        }
        public double multiplication()
        {
            return value1 * value2;

        }
        public double division()
        {
            return value1 / value2;

        }
        public double modulo()
        {
            return value1 % value2;

        }


    }

}
