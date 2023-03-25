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
        [Test]
        public void GivenSetOfRides_ShouldReturnTotalFair()
        {
            Ride[] rides = { new Ride(1.0f, 2.0f), new Ride(2.0f, 4.0f) };

            float totalFair = invoiceGenerator.CalculateFair(rides);
            Assert.AreEqual(36, totalFair);
        }

        [Test]
        public void GivenNullRides_ShouldReturnNullRideException()
        {
            Ride[] rides = null;
            try
            {
                float totalFair = invoiceGenerator.CalculateFair(rides);
            }
            catch (InvoiceGenerateException ex)
            {
                Assert.AreEqual("Null Rides", ex.Message);
            }
        }
    }
}