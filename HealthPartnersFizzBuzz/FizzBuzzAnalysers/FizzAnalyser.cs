﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPartnersFizzBuzz.FizzBuzzAnalyzers
{
    public class FizzAnalyser : IFizzBuzzAnalyser
    {
        public int Divisor { get { return 3; } }

        public string Analyse(int number)
        {
            if(number % Divisor == 0)
            {
                return "Fizz";
            }

            return number.ToString();
        }
    }
}
