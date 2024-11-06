using Microsoft.AspNetCore.Builder;
using MCQDAOnAbp.TrainingProgramService;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<TrainingProgramServiceWebTestModule>();

public partial class Program
{
}
