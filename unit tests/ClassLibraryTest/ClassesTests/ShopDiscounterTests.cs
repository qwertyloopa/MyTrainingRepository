using ClassLibrary.Classes;
using ClassLibrary.Interfaces;
using NUnit;
using Moq;


namespace ClassLibraryTest
{
    [TestFixture]
    internal class ShopDiscounterTests
    {
         private ShopDiscounter shopDiscounter;

        [SetUp]
        public void SetUp() // для первоначальной настройки всего скрипта
        {
            var mockLogger = new Mock<ILogger>();
            shopDiscounter = new ShopDiscounter(mockLogger.Object);
        }

        [Test]
        public void AddDiscountToItem_ShouldReturnCorrectResult_ForValidParameters()
        {
            var mockItem = new Mock<IItem>();
            mockItem.SetupProperty(i => i.Price, 100);
            var item = mockItem.Object;
            var discountPercent = 10;
            var expected = 90;

            var result = shopDiscounter.AddDiscountToItem(item, discountPercent);

            Assert.AreEqual(expected, result.Price);
        }

        [Test]
        public void AddDiscountToItem_ShouldThrowException_ForInvalidParameters()
        {

            var mockItem = new Mock<IItem>();
            mockItem.SetupProperty(i => i.Price, 100);

            var item = mockItem.Object;
            var discountPercent = -10;
            var expectedMessage = "Wrong discount percent";

           
            var ex = Assert.Throws<Exception>(() => shopDiscounter.AddDiscountToItem(item, discountPercent));
            Assert.AreEqual(expectedMessage, ex.Message);
        }
    }
}