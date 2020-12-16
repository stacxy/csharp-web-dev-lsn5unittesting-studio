using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void ContainsAnyChar()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void StringInBracketReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[launchcode]"));
        }

        [TestMethod]
        public void StringAndBracketReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("launch[code]"));
        }

        [TestMethod]
        public void StringsAndBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("launchcode[]"));
        }

        [TestMethod]
        public void NestedReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[LaunchCode]]"));
        }

        [TestMethod]
        public void OutOfOrderBracketReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void OnlyLeftBracketReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[launchcode"));
        }

        [TestMethod]
        public void OnlyRightBracketReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("launchcode]"));
        }


        [TestMethod]
        public void OpenBracketReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[launch[code]"));
        }
    }

   
}
