using Microsoft.AspNetCore.Builder;
using MCQDAOnAbp.QuestionBankService;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<QuestionBankServiceWebTestModule>();

public partial class Program
{
}
