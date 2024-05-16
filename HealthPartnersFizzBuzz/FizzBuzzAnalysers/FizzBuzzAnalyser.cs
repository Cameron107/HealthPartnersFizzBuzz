using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPartnersFizzBuzz.FizzBuzzAnalyzers
{
    public class FizzBuzzAnalyser : IFizzBuzzAnalyser
    {
        public int Divisor { get { return 15; } }

        public string Analyse(int number)
        {
            if(number % Divisor == 0)
            {
                return "FizzBuzz";
            }

            return number.ToString();
        }
    }
}
