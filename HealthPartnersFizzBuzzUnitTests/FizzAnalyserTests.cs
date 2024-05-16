using HealthPartnersFizzBuzz;
using HealthPartnersFizzBuzz.FizzBuzzAnalyzers;

namespace HealthPartnersFizzBuzzUnitTests
{
    [TestClass]
    public class FizzAnalyserTests
    {
        [TestMethod]
        public void FizzAnalyser_Returns_NumberAsAString()
        {
            var output = new FizzAnalyser().Analyse(4);
            Assert.AreEqual("4", output);
        }

        [TestMethod]
        public void FizzAnalyser_Divisor_is_three()
        {
            var output = new FizzAnalyser();
            Assert.AreEqual(3, output.Divisor);
        }
        [TestMethod]
        public void FizzAnalyser_Produces_Fizz_WhenGivenMultipleOfThree()
        {
            var output = new FizzAnalyser().Analyse(3);
            Assert.AreEqual("Fizz", output);
        }
    }
}