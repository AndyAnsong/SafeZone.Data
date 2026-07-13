using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SafeZone.Data.Context;

namespace SafeZone.Data;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSafeZoneData(
        this IServiceCollection services,
        string connectionString)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));

        return services;
    }
}