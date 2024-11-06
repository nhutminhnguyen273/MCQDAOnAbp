using Xunit;

namespace MCQDAOnAbp.FacultyService.EntityFrameworkCore;

[CollectionDefinition(FacultyServiceTestConsts.CollectionDefinitionName)]
public class FacultyServiceEntityFrameworkCoreCollection : ICollectionFixture<FacultyServiceEntityFrameworkCoreFixture>
{

}
