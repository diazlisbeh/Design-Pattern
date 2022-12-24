// Concrect product
public class StoreSale : ISale{

    private decimal _extra;
    public StoreSale(decimal extra){
        _extra = extra;
    }
  public void Sell(decimal total){

    Console.WriteLine($"La venta en tienda tiene un total de {total + _extra} pesos");
    

  }

}

