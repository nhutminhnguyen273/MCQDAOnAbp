using MCQDAOnAbp.Shared.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace MCQDAOnAbp.Keycloak.DbMigrator;

[DependsOn(
    typeof(MCQDAOnAbpSharedHostingModule)
)]
public class MCQDAOnAbpDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var configuration = context.Services.GetConfiguration();

        Configure<KeycloakClientOptions>(options =>
        {
            options.Url = configuration["Keycloak:url"];
            options.AdminUserName = configuration["Keycloak:adminUsername"];
            options.AdminPassword = configuration["Keycloak:adminPassword"];
            options.RealmName = configuration["Keycloak:realmName"];
        });
    }
}
