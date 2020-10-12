using NUnit.Framework;
using ShoppingCartLibrary;

namespace ShoppingCartTests
{
    public class ProductBTests
    {
        private ITerminal _terminal;
        
        [SetUp]
        public void Setup()
        {
            _terminal = new Terminal();
        }

        [Test]
        public void Individual_B_Is_Twelve_Dollars()
        {
            _terminal.Scan("B");
            Assert.AreEqual(_terminal.Total(), 12.00m);
            Assert.Greater(_terminal.Total(), 0.0m);
            Assert.Less(_terminal.Total(), 12.01m);
        }
        
        [Test]
        public void Three_B_Is_Thirty_Six_Dollars()
        {
            _terminal.Scan("B");
            _terminal.Scan("B");
            _terminal.Scan("B");
            Assert.AreEqual(_terminal.Total(), 36.00m);
        }
    }
}