using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MCQDAOnAbp.QuestionBankService.Data;
using Volo.Abp.DependencyInjection;

namespace MCQDAOnAbp.QuestionBankService.EntityFrameworkCore;

public class EntityFrameworkCoreQuestionBankServiceDbSchemaMigrator
    : IQuestionBankServiceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreQuestionBankServiceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the QuestionBankServiceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<QuestionBankServiceDbContext>()
            .Database
            .MigrateAsync();
    }
}
