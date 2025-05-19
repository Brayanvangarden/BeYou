using BeYou.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BeYou.WebAPI.Configuration;

public static class DBConfigurationExtension
{
    public static void ConfigureDataBase(this IServiceCollection services, IConfiguration configuration)
    {
        ArgumentNullException.ThrowIfNull(services);

        services.AddDbContext<BeYouContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("BeYouDataBase"),
                sqlServerOption =>
                {
                    sqlServerOption.EnableRetryOnFailure();
                })
        );
    }
}
