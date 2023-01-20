namespace Example
{
    //Creator
    public abstract class SaleFactory
    {
        public abstract ISale GetSale();
        
    }
    //Concrect Podect
    public class StoreSale : ISale
    {
        private decimal _extra;
        public StoreSale(decimal extra){
            _extra = extra;
        }
        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta ha sido realizada por {total + _extra}");
        }
    }

    //Product
    public interface ISale{
        public void Sell (decimal total);
    }
}