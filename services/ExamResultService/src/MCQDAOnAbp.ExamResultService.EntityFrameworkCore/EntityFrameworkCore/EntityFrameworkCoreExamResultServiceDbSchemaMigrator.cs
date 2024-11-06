using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MCQDAOnAbp.ExamResultService.Data;
using Volo.Abp.DependencyInjection;

namespace MCQDAOnAbp.ExamResultService.EntityFrameworkCore;

public class EntityFrameworkCoreExamResultServiceDbSchemaMigrator
    : IExamResultServiceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreExamResultServiceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ExamResultServiceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ExamResultServiceDbContext>()
            .Database
            .MigrateAsync();
    }
}
