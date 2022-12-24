// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


SaleFactory storeFactory = new StoreSaleFactory(10);
SaleFactory internetSale = new InternetSaleFactory(2);

ISale sale1 = storeFactory.GetSale();


decimal extra = 10;

List<ISale> listSales = new List<ISale>();

for(int i = 0;i<=10;i++)
{
    listSales.Add(storeFactory.GetSale());
}

foreach (var item in listSales)
{
    item.Sell(1);
}