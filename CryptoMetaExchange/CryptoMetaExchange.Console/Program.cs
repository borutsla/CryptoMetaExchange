using CryptoMetaExchange.Common.Interfaces;
using CryptoMetaExchange.Console;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    public static async Task Main(string[] args)
    {
        // Set up dependency injection
        var serviceProvider = Startup.ConfigureServices();

        // DI services
        var orderBookService = serviceProvider.GetService<IOrderBookService>();

        using var cts = new CancellationTokenSource();

        // Register cancellation handling for Ctrl+C
        RegisterCancellationHandling(cts);

        try
        {
            // Load the order book data
            var orderBook = await orderBookService!.LoadOrderBookAsync(@"Data\order-book-sample.json", cts.Token);

        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Operation was canceled.");
        }
    }

    private static void RegisterCancellationHandling(CancellationTokenSource cts)
    {
        Console.CancelKeyPress += (sender, eventArgs) =>
        {
            eventArgs.Cancel = true;
            cts.Cancel();
        };
    }
}