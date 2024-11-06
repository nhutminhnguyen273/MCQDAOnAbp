using Volo.Abp.Application;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace MCQDAOnAbp.FacultyService;

[DependsOn(
    typeof(FacultyServiceDomainModule),
    typeof(FacultyServiceApplicationContractsModule),
    typeof(AbpDddApplicationModule)
    )]
public class FacultyServiceApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<FacultyServiceApplicationModule>();
        });
    }
}
