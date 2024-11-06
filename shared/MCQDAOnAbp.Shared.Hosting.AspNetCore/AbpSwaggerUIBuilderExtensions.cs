using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.SwaggerUI;
using Volo.Abp.Swashbuckle;

namespace MCQDAOnAbp.Shared.Hosting.AspNetCore;

public static class AbpSwaggerUIBuilderExtensions
{
    public static IApplicationBuilder UseAbpSwaggerWithCustomScripUI(this IApplicationBuilder app, Action<SwaggerUIOptions>? setupAction = null)
    {
        var resolver = app.ApplicationServices.GetService<ISwaggerHtmlResolver>();

        return app.UseSwaggerUI(options =>
        {
            options.InjectJavascript("ui/abp.io");
            options.InjectJavascript("ui/abp.swagger.js");
            options.InjectJavascript("ui/requestinterceptor.js");
            options.IndexStream = () => resolver?.Resolver();

            setupAction?.Invoke(options);
        });
    }
}
