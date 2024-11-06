using MCQDAOnAbp.Shared.Localization.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace MCQDAOnAbp.Shared.Localization;

[DependsOn(
    typeof(AbpValidationModule)
)]
public class MCQDAOnAbpSharedLocalizationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<MCQDAOnAbpSharedLocalizationModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<MCQDAOnAbpResource>("en")
                .AddBaseTypes(
                    typeof(AbpValidationResource)
                ).AddVirtualJson("/Localization/MCQDAOnAbp");

            options.DefaultResourceType = typeof(AbpValidationResource);
        });
    }
}
