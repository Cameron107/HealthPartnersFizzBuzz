using HealthPartnersFizzBuzz;
using HealthPartnersFizzBuzz.FizzBuzzAnalyzers;

namespace HealthPartnersFizzBuzzUnitTests
{
    [TestClass]
    public class BuzzAnalyserTests
    {

        [TestMethod]
        public void BuzzAnalyser_Returns_NumberAsAString()
        {
            var output = new BuzzAnalyser().Analyse(4);
            Assert.AreEqual("4", output);
        }

        [TestMethod]
        public void BuzzAnalyser_Divisor_is_five()
        {
            var output = new BuzzAnalyser();
            Assert.AreEqual(5, output.Divisor);
        }

        [TestMethod]
        public void BuzzAnalyser_Produces_Buzz_WhenGivenMultipleOfFive()
        {
            var output = new BuzzAnalyser().Analyse(5);
            Assert.AreEqual("Buzz", output);
        }
    }
}