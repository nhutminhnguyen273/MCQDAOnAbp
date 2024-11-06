using Volo.Abp.Autofac;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace MCQDAOnAbp.Shared.Hosting
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpDataModule)
    )]
    public class MCQDAOnAbpSharedHostingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            ConfigureDatabaseConnections();
        }

        private void ConfigureDatabaseConnections()
        {
            Configure<AbpDbConnectionOptions>(options =>
            {
                options.Databases.Configure("AdministrationService", database =>
                {
                    database.MappedConnections.Add("AbpAuditLogging");
                    database.MappedConnections.Add("AbpPermissionManagement");
                    database.MappedConnections.Add("AbpSettingManagement");
                    database.MappedConnections.Add("AbpBlogStoring");
                });

                options.Databases.Configure("IdentityService", database =>
                {
                    database.MappedConnections.Add("AbpIdentity");
                    database.MappedConnections.Add("AbpIdentityServer");
                });
            });
        }
    }
}
