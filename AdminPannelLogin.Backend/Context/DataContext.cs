using AdminPannelLogin.Backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminPannelLogin.Backend.Context;

public class DataContext : DbContext
{
    private readonly IConfiguration _configuration;

    public DataContext(IConfiguration configuration) : base()
    {
        _configuration = configuration;
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        
        var connectionString = _configuration.GetConnectionString("MariaDbConnectionString");
        options.UseMySql(connectionString,new MariaDbServerVersion(new Version(11, 1, 2)));
    }

    public DbSet<MenuItem> MenuItems { get; set; }
}