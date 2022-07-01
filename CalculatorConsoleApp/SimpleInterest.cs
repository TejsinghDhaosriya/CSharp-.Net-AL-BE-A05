using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    public class SimpleInterest:ICalculator
    {
        private static IMath _iMath;

        public  SimpleInterest(IMath iMath)
        { _iMath = iMath;
        }

        public double Interest(double principal, double time, double rate)
        {
            return  _iMath.Divide(_iMath.Multiply(principal, rate, time), 100);
        }
    }
}
