public class InternetSale : ISale{

    private decimal _discount;
    public InternetSale(decimal discount){
        _discount = discount;
    }
  public void Sell(decimal total){

    Console.WriteLine($"La venta en tienda tiene un total de {total + _discount} pesos");
    

  }

}
