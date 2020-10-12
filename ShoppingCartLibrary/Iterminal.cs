namespace ShoppingCartLibrary
{
    public interface ITerminal
    {
        void Scan(string item);
        decimal Total();
    }
}