using CryptoMetaExchange.Common.Enums;

namespace CryptoMetaExchange.Common.Models;

public class Order
{
    required public DateTime Time { get; set; }
    required public OrderType Type { get; set; }
    required public OrderKind Kind { get; set; }
    required public decimal Amount { get; set; }
    required public decimal Price { get; set; }
}
