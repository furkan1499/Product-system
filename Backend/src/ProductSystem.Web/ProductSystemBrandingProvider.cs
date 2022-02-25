using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ProductSystem.Web;

[Dependency(ReplaceServices = true)]
public class ProductSystemBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ProductSystem";
}
