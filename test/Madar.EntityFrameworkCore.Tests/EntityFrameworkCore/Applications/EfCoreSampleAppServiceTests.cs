using Madar.Samples;
using Xunit;

namespace Madar.EntityFrameworkCore.Applications;

[Collection(MadarTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<MadarEntityFrameworkCoreTestModule>
{

}
