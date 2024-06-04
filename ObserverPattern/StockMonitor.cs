using ObserverPattern.Observers;
using ObserverPattern.Subjects;

namespace ObserverPattern
{
    public class StockMonitor
    {
        static void Main(string[] args)
        {
            var stock = new StockData();
            var currentPriceDisplay = new CurrentPriceDisplay(stock);

            stock.SetPrice("AAPL", 150.0f);
            stock.SetPrice("AAPL", 152.0f);
            stock.SetPrice("AAPL", 149.0f);
            stock.SetPrice("GOOG", 1000.0f);
            stock.SetPrice("GOOG", 1005.0f);
        }
    }
}
