namespace BlazorPlayGround.Interfaces;

public class CounterService : ICounters
{
    public List<int> Counters { get; } = []; // На всех уровнях уже гарантируем, что он никогда не Null
}

public static class CounterServiceExtensions
{
    public static IServiceCollection AddCounterService(this IServiceCollection services)
    {
        services.AddScoped<ICounters, CounterService>();
        return services;
    }
}