using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.Http.Client;

namespace MCQDAOnAbp.FacultyService;

[DependsOn(
    typeof(FacultyServiceApplicationContractsModule),
    typeof(AbpHttpClientModule)
)]
public class FacultyServiceHttpApiClientModule : AbpModule
{
    public const string RemoteServiceName = "Faculty";

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(FacultyServiceApplicationContractsModule).Assembly,
            RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<FacultyServiceHttpApiClientModule>();
        });
    }
}
