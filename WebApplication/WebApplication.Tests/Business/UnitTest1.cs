
using ClassLibrary;
using NUnit.Framework;

namespace WebApplication.Tests.Business
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            //Arrange
            //Act
            var customer = new Customer("Richard","Wysocki");
            //Assert
            Assert.That(customer.Name()=="Richard, Wysocki", $"This should be Right: {customer.Name()}");
        }
    }
}
