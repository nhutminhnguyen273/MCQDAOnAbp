using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MCQDAOnAbp.QuestionBankService.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class QuestionBankServiceDbContextFactory : IDesignTimeDbContextFactory<QuestionBankServiceDbContext>
{
    public QuestionBankServiceDbContext CreateDbContext(string[] args)
    {
        QuestionBankServiceEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<QuestionBankServiceDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new QuestionBankServiceDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MCQDAOnAbp.QuestionBankService.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
