using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SplitwiseAbp.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class SplitwiseAbpDbContextFactory : IDesignTimeDbContextFactory<SplitwiseAbpDbContext>
{
    public SplitwiseAbpDbContext CreateDbContext(string[] args)
    {
        SplitwiseAbpEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<SplitwiseAbpDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new SplitwiseAbpDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../SplitwiseAbp.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
