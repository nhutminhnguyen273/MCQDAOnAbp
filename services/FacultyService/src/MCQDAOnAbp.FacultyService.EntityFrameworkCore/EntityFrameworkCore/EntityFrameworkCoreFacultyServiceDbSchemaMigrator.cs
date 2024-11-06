using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MCQDAOnAbp.FacultyService.Data;
using Volo.Abp.DependencyInjection;

namespace MCQDAOnAbp.FacultyService.EntityFrameworkCore;

public class EntityFrameworkCoreFacultyServiceDbSchemaMigrator
    : IFacultyServiceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreFacultyServiceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the FacultyServiceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<FacultyServiceDbContext>()
            .Database
            .MigrateAsync();
    }
}
