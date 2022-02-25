using ProductSystem.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ProductSystem.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ProductSystemController : AbpControllerBase
{
    protected ProductSystemController()
    {
        LocalizationResource = typeof(ProductSystemResource);
    }
}
