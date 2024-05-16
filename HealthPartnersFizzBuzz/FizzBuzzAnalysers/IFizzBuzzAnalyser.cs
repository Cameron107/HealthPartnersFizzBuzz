using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPartnersFizzBuzz.FizzBuzzAnalyzers
{
    internal interface IFizzBuzzAnalyser
    {
        int Divisor { get; }
        int Analyse(int number);
    }
}
