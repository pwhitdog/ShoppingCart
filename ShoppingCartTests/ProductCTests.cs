using NUnit.Framework;
using ShoppingCartLibrary;

namespace ShoppingCartTests
{
    public class ProductCTests
    {
        private ITerminal _terminal;
        
        [SetUp]
        public void Setup()
        {
            _terminal = new Terminal();
        }

        [Test]
        public void Individual_C_Is_One_Dollar_Twenty_Five()
        {
            _terminal.Scan("C");
            Assert.AreEqual(1.25m, _terminal.Total());
            Assert.AreNotEqual(1.50m, _terminal.Total());
        }
        
        [Test]
        public void Five_C_Is_Six_Dollars_Twenty_Five()
        {
            for (var i = 0; i < 5; i++)
            {
               _terminal.Scan("C");
            }
            Assert.AreEqual(6.25m, _terminal.Total());
        }
        
        [Test]
        public void Six_C_Is_Six_Dollars()
        {
            for (var i = 0; i < 6; i++)
            {
                _terminal.Scan("C");
            }
            Assert.AreEqual(6.00m, _terminal.Total());
        }
        
        [Test]
        public void Fourteen_C_Is_Fourteen_Dollars_Fifty()
        {
            for (var i = 0; i < 14; i++)
            {
                _terminal.Scan("C");
            }
            Assert.AreEqual(14.50m, _terminal.Total());
        }
    }
}