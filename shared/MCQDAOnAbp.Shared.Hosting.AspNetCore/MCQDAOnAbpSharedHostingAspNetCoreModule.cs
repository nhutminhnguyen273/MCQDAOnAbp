using MCQDAOnAbp.Shared.Localization;
using Volo.Abp.AspNetCore.Serilog;
using Volo.Abp.Modularity;
using Volo.Abp.Swashbuckle;
using Volo.Abp.VirtualFileSystem;

namespace MCQDAOnAbp.Shared.Hosting.AspNetCore;

[DependsOn(
    typeof(MCQDAOnAbpSharedHostingModule),
    typeof(MCQDAOnAbpSharedLocalizationModule),
    typeof(AbpAspNetCoreSerilogModule),
    typeof(AbpSwashbuckleModule)
)]
public class MCQDAOnAbpSharedHostingAspNetCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<MCQDAOnAbpSharedHostingAspNetCoreModule>("MCQDAOnAbp.Shared.Hosting.AspNetCore");
        });
    }
}