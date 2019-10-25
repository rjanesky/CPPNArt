using System;

namespace Distributions
{
    public class Uniform : Distribution<double>
    {
        protected Uniform()
        {

        }

        public override double Next()
        {
            return nextDouble();
        }

        public static Distribution<double> GetInstance()
        {
            return new Uniform();
        }
    }
}
