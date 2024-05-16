using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPartnersFizzBuzz.FizzBuzzAnalyzers
{
    public class NumberAnalyser : IFizzBuzzAnalyser
    {
        public int Divisor { get { return 1; } }

        public string Analyse(int number)
        {
            if(number % Divisor == 0)
            {
                return number.ToString();
            }

            return number.ToString();
        }
    }
}
