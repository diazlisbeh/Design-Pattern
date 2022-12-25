public class InternetSaleFactory : SaleFactory
{
    private decimal _discount;

    public InternetSaleFactory(decimal discount){
        _discount = discount;
    }
    public override ISale GetSale()
    {
        return new StoreSale(_discount);
    }
}
