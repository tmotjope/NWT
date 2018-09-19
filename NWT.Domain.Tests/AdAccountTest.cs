using Microsoft.VisualStudio.TestTools.UnitTesting;
using NWT.Domain.Exceptions;
using NWT.Domain.ValueObjects;

namespace NWT.Domain.Tests
{
    [TestClass]
    public class AdAccountTest
    {
        [TestMethod]
        public void Should_Have_Domain()
        {
            var account = new AdAccount("aforbes\\motjopet");
            Assert.AreEqual("aforbes", account.Domain);
        }

        [TestMethod]
        public void Should_Have_Name()
        {
            var account = new AdAccount("aforbes\\motjopet");
            Assert.AreEqual("motjopet", account.Name);
        }

        [TestMethod]
        public void ToString_Returns_Domain_And_Name()
        {
            var value = "aforbes\\motjopet";
            var account = new AdAccount(value);
            Assert.AreEqual(value, account.ToString());
        }

        [TestMethod]
        public void Emplicit_Operator_Returns_Domain_And_Name()
        {
            var value = "aforbes\\motjopet";
            var account = new AdAccount(value);
            string result = account;

            Assert.AreEqual(value, result);
        }

        [TestMethod]
        public void Explicit_Operatore_Returns_Domain_And_Name()
        {
            var account = (AdAccount)"aforbes\\motjopet";        

            Assert.AreEqual("aforbes", account.Domain);
            Assert.AreEqual("motjopet", account.Name);
        }

        [TestMethod]
        public void Should_Throw_Execption()
        {
            var value = "aforbesmotjopet";
            Assert.ThrowsException<AdAccountInvalidException>(() => new AdAccount(value));
        }
    }
}
