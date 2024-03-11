using Xunit;

namespace Madar.EntityFrameworkCore;

[CollectionDefinition(MadarTestConsts.CollectionDefinitionName)]
public class MadarEntityFrameworkCoreCollection : ICollectionFixture<MadarEntityFrameworkCoreFixture>
{

}
