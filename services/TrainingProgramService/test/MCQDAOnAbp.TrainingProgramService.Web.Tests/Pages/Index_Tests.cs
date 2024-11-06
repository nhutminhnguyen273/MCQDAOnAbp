using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace MCQDAOnAbp.TrainingProgramService.Pages;

public class Index_Tests : TrainingProgramServiceWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
