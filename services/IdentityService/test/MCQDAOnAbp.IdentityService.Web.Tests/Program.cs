using Microsoft.AspNetCore.Builder;
using MCQDAOnAbp.IdentityService;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<IdentityServiceWebTestModule>();

public partial class Program
{
}
