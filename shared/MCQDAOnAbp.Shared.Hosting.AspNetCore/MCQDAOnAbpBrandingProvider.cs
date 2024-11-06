using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MCQDAOnAbp.Shared.Hosting.AspNetCore
{
    [Dependency(ReplaceServices = true)]
    public class MCQDAOnAbpBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "MCQDAOnAbp";
    }
}
