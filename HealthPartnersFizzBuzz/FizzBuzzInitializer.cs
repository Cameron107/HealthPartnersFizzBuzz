using HealthPartnersFizzBuzz.FizzBuzzAnalyzers;
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

            foreach(int number in FizzBuzzRange)
            {
                foreach(IFizzBuzzAnalyser analyser in AnalysersList)
                {
                    var analysis = analyser.Analyse(number);
                    FizzBuzzOutput.Add(analysis);
                }
            }

            return FizzBuzzOutput;
        }

        List<IFizzBuzzAnalyser> AnalysersList
        {
            get
            {
                var type = typeof(IFizzBuzzAnalyser);
                var Interfacetypes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                    .Where(y => type.IsAssignableFrom(y) && !y.IsInterface).Select(x => Activator.CreateInstance(x))
                    .Cast<IFizzBuzzAnalyser>();

                return Interfacetypes.ToList();
            }
        }
    }
}
