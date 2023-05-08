namespace InventoryStoreTests
{
    public class MeatTest
    {
        [Fact]
        public void Meat_GetsCreatedWith_CorrectPropeties()
        {
            InventoryStore.Meat meat1 = new InventoryStore.Meat("Steak");
            Assert.Equal("Steak", meat1.MeatName);
        }
        [Fact]
        public void Produce_GetsCreatedWith_CorrectProperties()
        {
            InventoryStore.Produce produce1 = new InventoryStore.Produce("Banana", "Corn");
            Assert.Equal("Banana", produce1.Fruits);
            Assert.Equal("Corn", produce1.Veggies);
        }
    }
}