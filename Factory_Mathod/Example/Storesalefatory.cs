//Concret Creator

public class StoreSaleFactory : SaleFactory
{
    private decimal _extra;

    public StoreSaleFactory(decimal extra){
        _extra = extra;
    }
    public override ISale GetSale()
    {
        return new StoreSale(_extra);
    }
}
