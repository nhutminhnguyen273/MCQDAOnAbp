﻿using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MCQDAOnAbp.TrainingProgramService.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class TrainingProgramServiceDbContextFactory : IDesignTimeDbContextFactory<TrainingProgramServiceDbContext>
{
    public TrainingProgramServiceDbContext CreateDbContext(string[] args)
    {
        TrainingProgramServiceEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<TrainingProgramServiceDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new TrainingProgramServiceDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MCQDAOnAbp.TrainingProgramService.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
