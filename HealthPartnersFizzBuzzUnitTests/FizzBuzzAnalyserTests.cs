using HealthPartnersFizzBuzz;
using HealthPartnersFizzBuzz.FizzBuzzAnalyzers;

namespace HealthPartnersFizzBuzzUnitTests
{
    [TestClass]
    public class FizzBuzzAnalyserTests
    {

        [TestMethod]
        public void FizzBuzzAnalyser_Returns_NumberAsAString()
        {
            var output = new FizzBuzzAnalyser().Analyse(14);
            Assert.AreEqual("14", output);
        }

        [TestMethod]
        public void FizzBuzzAnalyser_Divisor_is_fifteen()
        {
            var output = new FizzBuzzAnalyser();
            Assert.AreEqual(15, output.Divisor);
        }
        [TestMethod]
        public void FizzBuzzAnalyser_Produces_FizzBuzz_WhenGivenMultipleOfFifteen()
        {
            var output = new FizzBuzzAnalyser().Analyse(15);
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}