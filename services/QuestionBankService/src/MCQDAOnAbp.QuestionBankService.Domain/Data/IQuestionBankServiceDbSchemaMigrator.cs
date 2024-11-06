using System.Threading.Tasks;

namespace MCQDAOnAbp.QuestionBankService.Data;

public interface IQuestionBankServiceDbSchemaMigrator
{
    Task MigrateAsync();
}
