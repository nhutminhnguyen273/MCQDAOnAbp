using MCQDAOnAbp.FacultyService.Samples;
using Xunit;

namespace MCQDAOnAbp.FacultyService.EntityFrameworkCore.Applications;

[Collection(FacultyServiceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<FacultyServiceEntityFrameworkCoreTestModule>
{

}
