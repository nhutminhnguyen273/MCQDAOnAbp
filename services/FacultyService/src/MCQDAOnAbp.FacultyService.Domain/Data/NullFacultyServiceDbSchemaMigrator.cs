using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MCQDAOnAbp.FacultyService.Data;

/* This is used if database provider does't define
 * IFacultyServiceDbSchemaMigrator implementation.
 */
public class NullFacultyServiceDbSchemaMigrator : IFacultyServiceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
