using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IOCProject
{
    public class Divide : ICalculate
    {
        public double Calculate(double a, double b)
        {
            return b == 0 ? 0 : a / b;
        }
    }
}
