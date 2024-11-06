using MCQDAOnAbp.Shared.Hosting.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace MCQDAOnAbp.Shared.Hosting.Gateways
{
    [DependsOn(
        typeof(MCQDAOnAbpSharedHostingAspNetCoreModule)
    )]
    public class MCQDAOnAbpSharedHostingGatewaysModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();
            context.Services.AddHttpForwarderWithServiceDiscovery();
            context.Services.AddReverseProxy()
                .LoadFromConfig(configuration.GetSection("ReverseProxy"))
                .AddServiceDiscoveryDestinationResolver();
        }
    }
}
