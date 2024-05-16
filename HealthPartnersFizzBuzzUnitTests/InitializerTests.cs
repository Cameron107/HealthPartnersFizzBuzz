using HealthPartnersFizzBuzz;

namespace HealthPartnersFizzBuzzUnitTests
{
    [TestClass]
    public class InitializerTests
    {
        FizzBuzzInitializer _fizzBuzzInitializer;

        [TestInitialize]
        public void Setup()
        {
            _fizzBuzzInitializer = new FizzBuzzInitializer();
        }

        [TestMethod]
        public void RunFizzBuzz_Returns_NotEmptyList()
        {
            var output = _fizzBuzzInitializer.RunFizzBuzz();
            Assert.AreNotEqual(0, output.Count);
        }
    }
}