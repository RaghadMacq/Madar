using Volo.Abp.Modularity;

namespace Madar;

public abstract class MadarApplicationTestBase<TStartupModule> : MadarTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
