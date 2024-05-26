using CryptoMetaExchange.Common.Interfaces;
using CryptoMetaExchange.Common.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CryptoMetaExchange.Console;

public static class Startup
{
    public static ServiceProvider ConfigureServices()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddSingleton<IOrderBookService, OrderBookService>();

        return serviceCollection.BuildServiceProvider();
    }
}
