using System.Threading.Tasks;

namespace MCQDAOnAbp.ExamResultService.Data;

public interface IExamResultServiceDbSchemaMigrator
{
    Task MigrateAsync();
}
