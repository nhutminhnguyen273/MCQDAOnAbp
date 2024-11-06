using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MCQDAOnAbp.TrainingProgramService.Data;

/* This is used if database provider does't define
 * ITrainingProgramServiceDbSchemaMigrator implementation.
 */
public class NullTrainingProgramServiceDbSchemaMigrator : ITrainingProgramServiceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
