using CryptoMetaExchange.Common.Interfaces;
using CryptoMetaExchange.Common.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CryptoMetaExchange.Common.Services;

public class OrderBookService : IOrderBookService
{
    public async Task<OrderBook?> LoadOrderBookAsync(string filePath, CancellationToken ct)
    {
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
        };

        await using FileStream stream = File.OpenRead(filePath);
        return await JsonSerializer.DeserializeAsync<OrderBook>(stream, options, ct);
    }
}
