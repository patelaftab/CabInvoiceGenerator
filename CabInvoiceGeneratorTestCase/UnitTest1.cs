using CabInvoiceGenerator;
namespace CabInvoiceGeneratorTestCase
{
    public class InvoiceGeneraterTestCase
    {
       InvoiceGenerator invoiceGenerator=new InvoiceGenerator();
        [Test]
        public void GivenZeroValue_ShouldReturnCustomException()
        {
            try
            {
                float fair = invoiceGenerator.CalculateFair(1, 0);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid Time", ex.Message);
            }
        }
        [Test]
        public void GivenDistnceAndTime_ShouldReturnFair()
        {
            Assert.AreEqual(11, invoiceGenerator.CalculateFair(1, 1));
        }

        [Test]
        public void GivenMinDistnceAndMinTime_ShouldReturnDefaultFair()
        {
            Assert.AreEqual(5, invoiceGenerator.CalculateFair(0.1f, 0.1f));
        }
    }
}