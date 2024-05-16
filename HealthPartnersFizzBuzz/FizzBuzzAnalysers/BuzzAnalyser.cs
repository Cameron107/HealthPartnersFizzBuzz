using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPartnersFizzBuzz.FizzBuzzAnalyzers
{
    public class BuzzAnalyser : IFizzBuzzAnalyser
    {
        public int Divisor { get { return 5; } }

        public string Analyse(int number)
        {
            if(number % Divisor == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }
    }
}
