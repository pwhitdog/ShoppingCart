namespace ShoppingCartLibrary
{
    public class Terminal : ITerminal
    {
        private decimal _total;
        private int _aCount;        
        private int _cCount;
        
        public Terminal()
        {
            _total = 0.00m;
        }
        
        public void Scan(string item)
        {
            switch (item.ToUpper())
            {
                case "A":
                    _total += 2.00m;
                    _aCount += 1;
                    if (_aCount % 4 == 0)
                    {
                        _total -= 1.00m;
                    }
                    break;
                case "B":
                    _total += 12.00m;
                    break;
                case "C":
                    _total += 1.25m;
                    _cCount += 1;
                    if (_cCount % 6 == 0)
                    {
                        _total -= 1.50m;
                    }
                    break;
                case "D":
                    _total += .15m;
                    break;
            }
        }

        public decimal Total()
        {
            return _total;
        }
    }
}