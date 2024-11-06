using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace MCQDAOnAbp.ExamResultService.Pages;

public class Index_Tests : ExamResultServiceWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
