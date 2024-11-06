using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MCQDAOnAbp.FacultyService.EntityFrameworkCore;

public class FacultyServiceDbContextFactory : IDesignTimeDbContextFactory<FacultyServiceDbContext>
{
    public FacultyServiceDbContext CreateDbContext(string[] args)
    {
        FacultyServiceEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<FacultyServiceDbContext>()
            .UseSqlServer(configuration.GetConnectionString(FacultyServiceDbProperties.ConnectionStringName), b =>
            {
                b.MigrationsHistoryTable("__FacultyService_Migrations");
            });

        return new FacultyServiceDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), $"..{Path.DirectorySeparatorChar}MCQDAOnAbp.FacultyService.HttpApi.Host"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
