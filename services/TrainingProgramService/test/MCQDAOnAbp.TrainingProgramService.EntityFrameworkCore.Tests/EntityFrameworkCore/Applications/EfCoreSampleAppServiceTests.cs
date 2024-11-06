using MCQDAOnAbp.TrainingProgramService.Samples;
using Xunit;

namespace MCQDAOnAbp.TrainingProgramService.EntityFrameworkCore.Applications;

[Collection(TrainingProgramServiceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<TrainingProgramServiceEntityFrameworkCoreTestModule>
{

}
