using ClassLibrary.Classes;

namespace ClassLibraryTest
{
    [TestFixture]
    internal class ShopItemTests
    {
        [Test]
        public void ItShouldThowNullException_WhenNameIsNull()
        {
            string? name = null;
            decimal price = 10;
            string expectedMsg = "Value cannot be null. (Parameter 'name')";

            var ex = Assert.Throws<ArgumentNullException>( () => new ShopItem(name, price) );
            
            Assert.AreEqual(expectedMsg, ex.Message);
        }

        [Test]
        public void ItShouldThowNullException_WhenPriceIsNull()
        {
            string name = "Apple";
            decimal? price = null;
            string expectedMsg = "Value cannot be null. (Parameter 'price')";

            var ex = Assert.Throws<ArgumentNullException>( () => new ShopItem(name, price) );

            Assert.AreEqual(expectedMsg, ex.Message);
        }

        [Test]
        public void ItShouldTakeAllCorrectParams()
        {
            string name = "Apple";
            decimal price = 10;

            var item = new ShopItem(name, price);

            Assert.AreEqual(name, item.Name);
            Assert.AreEqual(price, item.Price);
        }
    }
}


