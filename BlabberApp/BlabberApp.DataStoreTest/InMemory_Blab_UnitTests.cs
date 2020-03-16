using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.DataStore;
using BlabberApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlabberApp.DataStoreTest
{
    [TestClass]
    public class InMemory_Blab_UnitTests
    {
        private InMemory<Blab> _harness;

        public InMemory_Blab_UnitTests()
        {
            var options = new DbContextOptionsBuilder<ApplicationContext>()
                             .UseInMemoryDatabase(databaseName: "Add_writes")
                             .Options;
            _harness = new InMemory<Blab>(new ApplicationContext(options));
        }

        [TestMethod]
        public void Add_Blab_GetByUserId_Success()
        {
            //Arrange
            string Email = "foo@example.com";
            Blab Expected = new Blab();
            Expected.Message = "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested.";
            Expected.UserID = Email;
            var sysId = Expected.getSysId();
            _harness.Add(Expected);
            // Act
            Blab Actual = (Blab)_harness.GetByUserId(Email);
            // Assert
            Assert.AreEqual(Expected, Actual);
        }
    }
}
