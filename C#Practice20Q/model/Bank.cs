using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Model
{
    class Bank
    {
        public static double InterestRate { get; private set; }
        public static void SetInterestRate(double newRate)
        {
            InterestRate = newRate;
        }
    }
}


