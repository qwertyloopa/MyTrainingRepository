using ClassLibrary;
using ClassLibrary.Interfaces;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Engine;
using Moq;

namespace ClassLibraryTest
{
    [TestFixture]
    public class ShopTests
    {
        [SetUp]
        public void SetUp()
        {
            Mock<IShopDiscounter> discounterMock = new Mock<IShopDiscounter>();
            Mock<ILogger> loggerMock = new Mock<ILogger>();
            IItem item = new ShopItem("Apple", 10);
            Mock<IDb> dbMock = new Mock<IDb>();
            Shop testShop = new Shop(discounterMock.Object, loggerMock.Object, dbMock.Object);
        }

        [Test]
        public void ItBuyingAnItem()
        {
            
        }

        [Test]
        public void ItMakingDiscount() { }
    }
}