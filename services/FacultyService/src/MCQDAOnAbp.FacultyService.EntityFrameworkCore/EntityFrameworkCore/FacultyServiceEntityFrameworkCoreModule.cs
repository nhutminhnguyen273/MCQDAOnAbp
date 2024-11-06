using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.Modularity;

namespace MCQDAOnAbp.FacultyService.EntityFrameworkCore;

[DependsOn(
    typeof(FacultyServiceDomainModule),
    typeof(AbpEntityFrameworkCoreSqlServerModule)
    )]
public class FacultyServiceEntityFrameworkCoreModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        FacultyServiceEfCoreEntityExtensionMappings.Configure();
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<FacultyServiceDbContext>(options =>
        {
            options.ReplaceDbContext<FacultyServiceDbContext>();

            options.AddDefaultRepositories(includeAllEntities: true);
        });

        Configure<AbpDbContextOptions>(options =>
        {
            options.Configure<FacultyServiceDbContext>(c =>
            {
                c.UseSqlServer(b => { b.MigrationsHistoryTable("__FacultyService_Migrations"); });
            });
        });

    }
}
