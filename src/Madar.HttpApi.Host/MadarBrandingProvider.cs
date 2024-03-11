using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Madar;

[Dependency(ReplaceServices = true)]
public class MadarBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Madar";
}
