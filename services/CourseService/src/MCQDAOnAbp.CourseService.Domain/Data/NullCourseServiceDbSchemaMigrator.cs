using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MCQDAOnAbp.CourseService.Data;

/* This is used if database provider does't define
 * ICourseServiceDbSchemaMigrator implementation.
 */
public class NullCourseServiceDbSchemaMigrator : ICourseServiceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
