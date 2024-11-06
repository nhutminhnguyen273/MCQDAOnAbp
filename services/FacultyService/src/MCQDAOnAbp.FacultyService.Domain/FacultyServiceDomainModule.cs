using Volo.Abp.Modularity;
using Volo.Abp.Domain;
using Volo.Abp.AutoMapper;
using Volo.Abp.Domain.Entities.Events.Distributed;
using MCQDAOnAbp.FacultyService.Entities;
using MCQDAOnAbp.FacultyService.ETOs;

namespace MCQDAOnAbp.FacultyService;

[DependsOn(
    typeof(FacultyServiceDomainSharedModule),
    typeof(AbpDddDomainModule),
    typeof(AbpAutoMapperModule)
)]
public class FacultyServiceDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options => { options.AddMaps<FacultyServiceDomainModule>(validate: true); });

        Configure<AbpDistributedEntityEventOptions>(options =>
        {
            options.AutoEventSelectors.Add<Faculty>();
            options.EtoMappings.Add<Faculty, FacultyEto>();
        });
    }
}
