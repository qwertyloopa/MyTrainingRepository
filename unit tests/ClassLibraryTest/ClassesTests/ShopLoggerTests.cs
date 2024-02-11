using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Classes;
using ClassLibrary.Interfaces;
using Moq;

namespace ClassLibraryTest
{
    [TestFixture]
    internal class ShopLoggerTests
    {
 
            static Mock<IDb> dbMock = new Mock<IDb>(); 
            ShopLogger logger = new ShopLogger(dbMock.Object);

        [Test]
        public void ItShouldContainWarnMessage()
        {
            string mes = "test message";
            dbMock.Setup(x => x.AddLogRecord(It.IsAny<string>()));

            logger.Warn(mes);

            dbMock.Verify(x => x.AddLogRecord($"WARN: {mes}"));
        }

        [Test]
        public void ItShouldContainInfoMessage()
        {
            string mes = "test message";
            dbMock.Setup(x => x.AddLogRecord(It.IsAny<string>()));

            logger.Info(mes);

            dbMock.Verify(x => x.AddLogRecord($"INFO: {mes}"));
        }

        [Test]
        public void ItShouldCheckBoolean()
        {
            
        }
    }
}
