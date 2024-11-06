using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MCQDAOnAbp.TrainingProgramService.Data;
using Volo.Abp.DependencyInjection;

namespace MCQDAOnAbp.TrainingProgramService.EntityFrameworkCore;

public class EntityFrameworkCoreTrainingProgramServiceDbSchemaMigrator
    : ITrainingProgramServiceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTrainingProgramServiceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the TrainingProgramServiceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TrainingProgramServiceDbContext>()
            .Database
            .MigrateAsync();
    }
}
