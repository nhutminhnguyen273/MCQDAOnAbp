using Microsoft.AspNetCore.Builder;
using MCQDAOnAbp.ExamResultService;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<ExamResultServiceWebTestModule>();

public partial class Program
{
}
