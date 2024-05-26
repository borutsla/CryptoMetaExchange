namespace CryptoMetaExchange.Common.Models;

public class OrderBook
{
    public DateTime AcqTime { get; set; }
    required public List<OrderBookEntry> Bids { get; set; }
    required public List<OrderBookEntry> Asks { get; set; }
}
