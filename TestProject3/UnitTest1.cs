using NUnit.Framework;

namespace TestProject3
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void Can_Add_To_Cart()
        {
            Product p1 = new Product { Id = 1, name = "A" };
            Product p2 = new Product { Id = 2, name = "b" };
            Cart cart = new Cart();
            cart.add(p1, 1);
            cart.add(p2, 1);

            CartItem[] _items = cart.Items.ToArray
        }
    }
}