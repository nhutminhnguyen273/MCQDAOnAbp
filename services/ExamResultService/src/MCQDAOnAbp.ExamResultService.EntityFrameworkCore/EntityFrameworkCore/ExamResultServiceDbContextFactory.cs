using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MCQDAOnAbp.ExamResultService.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class ExamResultServiceDbContextFactory : IDesignTimeDbContextFactory<ExamResultServiceDbContext>
{
    public ExamResultServiceDbContext CreateDbContext(string[] args)
    {
        ExamResultServiceEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ExamResultServiceDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new ExamResultServiceDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MCQDAOnAbp.ExamResultService.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
