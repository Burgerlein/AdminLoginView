using AdminPannelLogin.Backend.Context;
using AdminPannelLogin.Backend.Repositories;

namespace AdminPannelLogin.Backend;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        AddAspDotNetServices(services);
        
        services.AddDbContext<DataContext>(
            dbContextOptions => dbContextOptions
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors()
        );
        
        services.AddScoped<IMenuItemRepository, MenuItemRepository>();

    }

    private void AddAspDotNetServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddCors(options =>
        {
            options.AddPolicy(name: "MyAllowSpecificOrigins",
                corsPolicyBuilder => { corsPolicyBuilder.AllowAnyOrigin(); });
        });
    }
}