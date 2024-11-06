using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MCQDAOnAbp.QuestionBankService.Data;

/* This is used if database provider does't define
 * IQuestionBankServiceDbSchemaMigrator implementation.
 */
public class NullQuestionBankServiceDbSchemaMigrator : IQuestionBankServiceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
