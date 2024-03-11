using Volo.Abp.Modularity;

namespace Madar;

[DependsOn(
    typeof(MadarDomainModule),
    typeof(MadarTestBaseModule)
)]
public class MadarDomainTestModule : AbpModule
{

}
