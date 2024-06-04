using ObserverPattern.Interfaces;
using ObserverPattern.Subjects;

namespace ObserverPattern.Observers;

public class CurrentPriceDisplay : IObserver, IDisplay
{
    private readonly StockData _stockData;
    private Dictionary<string, float> _prices;

    public CurrentPriceDisplay(StockData stockData)
    {
        _stockData = stockData;
        stockData.RegisterObserver(this);
    }
    public void Update()
    {
        _prices = _stockData.StockPrices;
        Display();
    }

    public void Display()
    {
        foreach (var stockPrice in _prices)
        {
            Console.WriteLine("Stock : {0}, Price: {1}", stockPrice.Key, stockPrice.Value);
        }
    }
}