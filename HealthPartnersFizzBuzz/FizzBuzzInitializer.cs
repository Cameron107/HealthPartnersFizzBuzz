using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPartnersFizzBuzz
{
    public class FizzBuzzInitializer
    {
        public List<int> RunFizzBuzz()
        {
            List<int> FizzBuzzRange = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                FizzBuzzRange.Add(i);
            }

            return FizzBuzzRange;
        }
    }
}
