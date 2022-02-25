using ProductSystem.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ProductSystem.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProductSystemEntityFrameworkCoreModule),
    typeof(ProductSystemApplicationContractsModule)
    )]
public class ProductSystemDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
