using MCQDAOnAbp.FacultyService.Samples;
using Xunit;

namespace MCQDAOnAbp.FacultyService.EntityFrameworkCore.Domains;

[Collection(FacultyServiceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<FacultyServiceEntityFrameworkCoreTestModule>
{

}
