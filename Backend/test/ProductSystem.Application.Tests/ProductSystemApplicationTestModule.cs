using Volo.Abp.Modularity;

namespace ProductSystem;

[DependsOn(
    typeof(ProductSystemApplicationModule),
    typeof(ProductSystemDomainTestModule)
    )]
public class ProductSystemApplicationTestModule : AbpModule
{

}
