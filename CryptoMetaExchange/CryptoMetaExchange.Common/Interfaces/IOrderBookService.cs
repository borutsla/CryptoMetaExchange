using CryptoMetaExchange.Common.Models;

namespace CryptoMetaExchange.Common.Interfaces;

public interface IOrderBookService
{
    Task<OrderBook?> LoadOrderBookAsync(string filePath, CancellationToken ct);
}
