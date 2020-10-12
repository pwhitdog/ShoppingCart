using NUnit.Framework;
using ShoppingCartLibrary;

namespace ShoppingCartTests
{
    public class ProductATests
    {
        private ITerminal _terminal;
        
        [SetUp]
        public void Setup()
        {
            _terminal = new Terminal();
        }

        [Test]
        public void Individual_A_Is_Two_Dollars()
        {
            _terminal.Scan("A");
            Assert.AreEqual(2.00m, _terminal.Total() );
        }
        
        [Test]
        public void Individual_A_Is_Not_One_Dollar()
        {
            _terminal.Scan("A");
            Assert.AreNotEqual(1.00m, _terminal.Total());
        }
        
        [Test]
        public void Two_A_Is_Four_Dollars()
        {
            _terminal.Scan("A");
            _terminal.Scan("A");
            Assert.AreEqual(4.00m, _terminal.Total());
        }
        
        [Test]
        public void Three_A_Is_Six_Dollars()
        {
            _terminal.Scan("A");
            _terminal.Scan("A");
            _terminal.Scan("A");
            Assert.AreEqual(6.00m, _terminal.Total());
        }
        
        [Test]
        public void Four_A_Is_Seven_Dollars()
        {
            _terminal.Scan("A");
            _terminal.Scan("A");
            _terminal.Scan("A");
            _terminal.Scan("A");
            Assert.AreEqual(7.00m, _terminal.Total());
        }
        
        [Test]
        public void Five_A_Is_Nine_Dollars()
        {
            _terminal.Scan("A");
            _terminal.Scan("A");
            _terminal.Scan("A");
            _terminal.Scan("A");
            _terminal.Scan("A");
            Assert.AreEqual(9.00m, _terminal.Total());
        }
    }
}