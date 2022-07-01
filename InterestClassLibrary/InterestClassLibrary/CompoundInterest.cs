namespace InterestClassLibrary
{
    public class CompoundInterest : ICalculator
    {
        private static IMath _iMath;

        public CompoundInterest(IMath iMath)
        {
            _iMath = iMath;
        }

        public double Interest(double principal, double time, double rate)
        {
            // amount = p * Math.Pow((1 + r / 100), t);
            // compound interest = amount - p;
            var amount = _iMath.Multiply(principal,
                System.Math.Pow(_iMath.Add(1,
                    _iMath.Divide(rate, 100)), time));
            return _iMath.Subtract(amount, principal);
        }
    }
}