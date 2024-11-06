using MCQDAOnAbp.TrainingProgramService.Samples;
using Xunit;

namespace MCQDAOnAbp.TrainingProgramService.EntityFrameworkCore.Domains;

[Collection(TrainingProgramServiceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<TrainingProgramServiceEntityFrameworkCoreTestModule>
{

}
