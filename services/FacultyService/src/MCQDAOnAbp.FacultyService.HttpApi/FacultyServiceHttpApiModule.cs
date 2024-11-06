using Localization.Resources.AbpUi;
using MCQDAOnAbp.FacultyService.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace MCQDAOnAbp.FacultyService;

[DependsOn(
    typeof(FacultyServiceApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule)
    )]
public class FacultyServiceHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<FacultyServiceResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
