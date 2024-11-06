using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MCQDAOnAbp.CourseService.Data;
using Volo.Abp.DependencyInjection;

namespace MCQDAOnAbp.CourseService.EntityFrameworkCore;

public class EntityFrameworkCoreCourseServiceDbSchemaMigrator
    : ICourseServiceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCourseServiceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the CourseServiceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CourseServiceDbContext>()
            .Database
            .MigrateAsync();
    }
}
