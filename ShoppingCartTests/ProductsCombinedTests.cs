using NUnit.Framework;
using ShoppingCartLibrary;

namespace ShoppingCartTests
{
    public class ProductsCombinedTests
    {
        private ITerminal _terminal;
        
        [SetUp]
        public void Setup()
        {
            _terminal = new Terminal();
        }
        
        [Test]
        public void Scanned_Items_ABCDABAA_Are_Thirty_Two_Dollars_Forty()
        {
            _terminal.Scan("A");
            _terminal.Scan("B");
            _terminal.Scan("C");
            _terminal.Scan("D");
            _terminal.Scan("A");
            _terminal.Scan("B");
            _terminal.Scan("A");
            _terminal.Scan("A");
            Assert.AreEqual(_terminal.Total(), 32.40m);
        }
        
        [Test]
        public void Scanned_Seven_C_Are_Seven_Dollars_Twenty_Five()
        {
            for (var i = 0; i < 7; i++)
            {
                _terminal.Scan("C");
            }
            Assert.AreEqual(7.25m, _terminal.Total());
        }
        
        [Test]
        public void Scanned_Items_ABCD_Are_Fifteen_Dollars_Forty()
        {
            _terminal.Scan("A");
            _terminal.Scan("B");
            _terminal.Scan("C");
            _terminal.Scan("D");
            Assert.AreEqual(15.40m, _terminal.Total());
        }
    }
}