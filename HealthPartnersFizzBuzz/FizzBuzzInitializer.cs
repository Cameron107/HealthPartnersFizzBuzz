using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPartnersFizzBuzz
{
    public class FizzBuzzInitializer
    {
        public List<string> RunFizzBuzz()
        {
            List<int> FizzBuzzRange = new List<int>();
            List<string> FizzBuzzOutput = new List<string>();

            for (int i = 1; i <= 100; i++)
            {
                FizzBuzzRange.Add(i);
            }

            FizzBuzzOutput = FizzBuzzRange.ConvertAll(x => x.ToString());

            return FizzBuzzOutput;
        }
    }
}
