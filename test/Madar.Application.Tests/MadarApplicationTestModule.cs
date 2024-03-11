using Volo.Abp.Modularity;

namespace Madar;

[DependsOn(
    typeof(MadarApplicationModule),
    typeof(MadarDomainTestModule)
)]
public class MadarApplicationTestModule : AbpModule
{

}
