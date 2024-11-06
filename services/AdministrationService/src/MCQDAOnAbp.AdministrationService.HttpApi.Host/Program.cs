using System;
using System.Threading.Tasks;
using MCQDAOnAbp.Shared.Hosting.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Serilog;

namespace MCQDAOnAbp.AdministrationService;

public class Program
{
    public async static Task<int> Main(string[] args)
    {
        var assemblyName = typeof(Program).Assembly.GetName().Name;

        SerilogConfigurationHelper.Configure(assemblyName);

        try
        {
            Log.Information($"Starting {assemblyName}.");
            var app = await ApplicationBuilderHelper
                .BuildApplicationAsync<AdministrationServiceHttpApiHostModule>(args);
            await app.InitializeApplicationAsync();
            await app.RunAsync();
            return 0;
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Host terminated unexpectedly!");
            return 1;
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}
