using ProductSystem.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ProductSystem.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ProductSystemPageModel : AbpPageModel
{
    protected ProductSystemPageModel()
    {
        LocalizationResourceType = typeof(ProductSystemResource);
    }
}
