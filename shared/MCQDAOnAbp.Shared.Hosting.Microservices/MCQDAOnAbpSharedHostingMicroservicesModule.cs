using MCQDAOnAbp.AdministrationService.EntityFrameworkCore;
using MCQDAOnAbp.Shared.Hosting.AspNetCore;
using Medallion.Threading;
using Medallion.Threading.Redis;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Logging;
using StackExchange.Redis;
using Volo.Abp.AspNetCore.Authentication.JwtBearer;
using Volo.Abp.BackgroundJobs.RabbitMQ;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.DistributedLocking;
using Volo.Abp.EventBus.RabbitMq;
using Volo.Abp.Modularity;

namespace MCQDAOnAbp.Shared.Hosting.Microservices;

[DependsOn(
    typeof(MCQDAOnAbpSharedHostingAspNetCoreModule),
    typeof(AbpBackgroundJobsRabbitMqModule),
    typeof(AbpAspNetCoreAuthenticationJwtBearerModule),
    typeof(AbpEventBusRabbitMqModule),
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(AdministrationServiceEntityFrameworkCoreModule),
    typeof(AbpDistributedLockingModule)
)]
public class MCQDAOnAbpSharedHostingMicroservicesModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        IdentityModelEventSource.ShowPII = true;
        var configuration = context.Services.GetConfiguration();
        Configure<AbpDistributedCacheOptions>(options =>
        {
            options.KeyPrefix = "MCQDAOnAbp:";
        });

        var redis = ConnectionMultiplexer.Connect(configuration["Redis:Configuration"]!);
        context.Services.AddDataProtection().PersistKeysToStackExchangeRedis(redis, "EShopOnAbp-Protection-Keys");
        context.Services.AddSingleton<IDistributedLockProvider>(sp =>
        {
            var connection = ConnectionMultiplexer.Connect(configuration["Redis:Configuration"]!);
            return new RedisDistributedSynchronizationProvider(connection.GetDatabase());
        });
    }
}