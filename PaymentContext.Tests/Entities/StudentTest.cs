using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var student = new Student("Rodrigo", "Nappi", "123456789", "rodrigo_nappi@hotmail.com");
        }
    }
}