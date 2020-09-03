using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var subscription = new Subscription(null);
            var name = new Name("Eduardo","Oliveira");
            var document = new Document("258615111", Domain.Enums.EDocumentType.CPF);
            var email = new Email("eduardo@gmail.com");            
            var student = new Student(name, document,email);

            name.AddNotification("Teste", "Teste");
            
            student.AddSubscription(subscription);

        }
    }
}
