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
        string Analyse(int number);
    }
}
