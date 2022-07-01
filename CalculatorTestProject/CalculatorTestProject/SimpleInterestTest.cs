using InterestClassLibrary;
using Math = InterestClassLibrary.Math;

namespace CalculatorTestProject
{
    public class SimpleInterestTest
    {
        // integration test
        [Fact]
        public void ShouldReturnSimpleInterest()
        {
            double principleAmount = 10000;
            double time = 6;
            double rate = 4;

            var simpleInterest = new SimpleInterest(new Math());
            var interest = simpleInterest.Interest(principleAmount, time, rate);

            Assert.Equal(2400, System.Math.Truncate(100 * interest) / 100);
        }


        [Fact]
        public void ShouldReturnSimpleInterestForDecimalsData()
        {
            double principleAmount = 100006.359;
            double time = 56.2;
            double rate = 13.3;

            var simpleInterest = new SimpleInterest(new Math());
            var interest = simpleInterest.Interest(principleAmount, time, rate);

            Assert.Equal(747507.53, System.Math.Truncate(100*interest)/100);
        }
    }
}