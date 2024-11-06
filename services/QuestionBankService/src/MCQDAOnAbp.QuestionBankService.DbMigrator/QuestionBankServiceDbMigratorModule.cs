using MCQDAOnAbp.QuestionBankService.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MCQDAOnAbp.QuestionBankService.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(QuestionBankServiceEntityFrameworkCoreModule),
    typeof(QuestionBankServiceApplicationContractsModule)
    )]
public class QuestionBankServiceDbMigratorModule : AbpModule
{
}
