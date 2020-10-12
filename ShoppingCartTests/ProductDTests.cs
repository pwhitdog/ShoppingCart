using NUnit.Framework;
using ShoppingCartLibrary;

namespace ShoppingCartTests
{
    public class ProductDTests
    {
        private ITerminal _terminal;
        
        [SetUp]
        public void Setup()
        {
            _terminal = new Terminal();
        }

        [Test]
        public void Individual_D_Is_Zero_Dollars_Fifteen()
        {
            _terminal.Scan("D");
            Assert.AreEqual(_terminal.Total(), .15m);
            Assert.Greater(_terminal.Total(), 0.0m);
            Assert.Less(_terminal.Total(), .16m);
        }
        
        [Test]
        public void Three_D_Is_Zero_Dollars_Forty_Five()
        {
            _terminal.Scan("D");
            _terminal.Scan("D");
            _terminal.Scan("D");
            Assert.AreEqual(_terminal.Total(), .45m);
        }
    }
}