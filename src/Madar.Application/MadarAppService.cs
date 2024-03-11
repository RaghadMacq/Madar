using System;
using System.Collections.Generic;
using System.Text;
using Madar.Localization;
using Volo.Abp.Application.Services;

namespace Madar;

/* Inherit your application services from this class.
 */
public abstract class MadarAppService : ApplicationService
{
    protected MadarAppService()
    {
        LocalizationResource = typeof(MadarResource);
    }
}
