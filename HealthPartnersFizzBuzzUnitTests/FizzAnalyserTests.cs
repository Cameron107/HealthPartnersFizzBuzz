using HealthPartnersFizzBuzz;
using HealthPartnersFizzBuzz.FizzBuzzAnalyzers;

namespace HealthPartnersFizzBuzzUnitTests
{
    [TestClass]
    public class FizzAnalyserTests
    {

        FizzAnalyser _fizzAnalyser;

        [TestMethod]
        public void FizzAnalyser_Returns_String()
        {
            var output = _fizzAnalyser.Analyse(3);
            Assert.IsInstanceOfType(output, typeof(string));
        }
    }
}