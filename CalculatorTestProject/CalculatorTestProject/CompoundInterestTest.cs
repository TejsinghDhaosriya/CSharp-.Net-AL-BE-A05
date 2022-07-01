
using InterestClassLibrary;
using Math = InterestClassLibrary.Math;

namespace CalculatorTestProject
{
    public class CompoundInterestTest
    {
        [Fact]
        public void ShouldReturnSimpleInterest()
        {
            double principleAmount = 10000;
            double time = 6;
            double rate = 4;

            var compoundInterest = new CompoundInterest(new Math());
            var interest = compoundInterest.Interest(principleAmount, time, rate);

            Assert.Equal(2653.19, System.Math.Truncate(100 * interest) / 100);
        }


        [Fact]
        public void ShouldReturnSimpleInterestForDecimalsData()
        {
            double principleAmount = 24000.45;
            double time = 10.5;
            double rate = 9.5;

            var compoundInterest = new CompoundInterest(new Math());
            var interest = compoundInterest.Interest(principleAmount, time, rate);

            Assert.Equal(38239.27, System.Math.Truncate(100 * interest) / 100);
        }
    }
}
