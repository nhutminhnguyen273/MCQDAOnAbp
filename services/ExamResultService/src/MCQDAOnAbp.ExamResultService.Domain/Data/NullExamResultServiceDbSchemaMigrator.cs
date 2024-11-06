using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MCQDAOnAbp.ExamResultService.Data;

/* This is used if database provider does't define
 * IExamResultServiceDbSchemaMigrator implementation.
 */
public class NullExamResultServiceDbSchemaMigrator : IExamResultServiceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
