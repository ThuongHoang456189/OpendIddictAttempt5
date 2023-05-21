using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace OpendIddictAttempt4.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class OpendIddictAttempt4DbContextFactory : IDesignTimeDbContextFactory<OpendIddictAttempt4DbContext>
{
    public OpendIddictAttempt4DbContext CreateDbContext(string[] args)
    {
        OpendIddictAttempt4EfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<OpendIddictAttempt4DbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new OpendIddictAttempt4DbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../OpendIddictAttempt4.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
