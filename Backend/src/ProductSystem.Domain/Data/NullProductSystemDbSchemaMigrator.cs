using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ProductSystem.Data;

/* This is used if database provider does't define
 * IProductSystemDbSchemaMigrator implementation.
 */
public class NullProductSystemDbSchemaMigrator : IProductSystemDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
