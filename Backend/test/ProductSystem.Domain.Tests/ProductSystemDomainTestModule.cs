using ProductSystem.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ProductSystem;

[DependsOn(
    typeof(ProductSystemEntityFrameworkCoreTestModule)
    )]
public class ProductSystemDomainTestModule : AbpModule
{

}
