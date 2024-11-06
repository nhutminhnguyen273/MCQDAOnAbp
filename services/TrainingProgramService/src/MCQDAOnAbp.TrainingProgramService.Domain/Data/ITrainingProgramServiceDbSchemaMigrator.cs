using System.Threading.Tasks;

namespace MCQDAOnAbp.TrainingProgramService.Data;

public interface ITrainingProgramServiceDbSchemaMigrator
{
    Task MigrateAsync();
}
