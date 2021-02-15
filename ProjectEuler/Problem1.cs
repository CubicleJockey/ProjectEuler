using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEuler
{
    /// <summary>
    /// Multiples of 3 and 5
    /// Problem 1
    ///
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    ///
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    [TestClass]
    public class Problem1
    {
        [TestMethod]
        public void Solution()
        {
            var result = 0;
            for(var i = 3; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    result += i;
                }
            }

            _ = result.Should().Be(233168);
        }
    }
}
