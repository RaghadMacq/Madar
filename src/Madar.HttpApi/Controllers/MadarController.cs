using Madar.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Madar.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MadarController : AbpControllerBase
{
    protected MadarController()
    {
        LocalizationResource = typeof(MadarResource);
    }
}
