using HealthPartnersFizzBuzz;
using HealthPartnersFizzBuzz.FizzBuzzAnalyzers;

namespace HealthPartnersFizzBuzzUnitTests
{
    [TestClass]
    public class FizzAnalyserTests
    {

        FizzAnalyser _fizzAnalyser;

        [TestMethod]
        public void FizzAnalyser_Returns_NumberAsAString()
        {
            var output = new FizzAnalyser().Analyse(3);
            Assert.AreEqual("3", output);
        }

        public void FizzAnalyser_Divisor_is_three()
        {
            var output = new FizzAnalyser();
            Assert.AreEqual(3, output.Divisor);
        }
    }
}