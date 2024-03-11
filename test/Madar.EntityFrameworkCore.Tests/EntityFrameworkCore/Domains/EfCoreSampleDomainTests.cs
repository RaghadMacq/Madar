using Madar.Samples;
using Xunit;

namespace Madar.EntityFrameworkCore.Domains;

[Collection(MadarTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<MadarEntityFrameworkCoreTestModule>
{

}
