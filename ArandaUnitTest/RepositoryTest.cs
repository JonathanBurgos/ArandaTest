using ArandaBusiness.Repositories.Implementations;
using ArandaData.Connection;
using ArandaData.Connection.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArandaUnitTest
{
    [TestClass]
    public class RepositoryTest
    {
        private GenericRepository _gp;
        [TestInitialize]
        public void Initializetion()
        {
             _gp = new GenericRepository(ArandaDbContext.Create());
        }

        [TestMethod]
        public void return_stringIpAddress()
        {            
            string result = _gp.GetLocalIPAddress();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void return_stringHardDisk()
        {           
            string result = _gp.GetLocalHardDisk();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void return_stringVersionSystem()
        {            
            string result = _gp.GetVersonSystem();

            Assert.IsTrue(!string.IsNullOrEmpty(result));
        }
    }
}
