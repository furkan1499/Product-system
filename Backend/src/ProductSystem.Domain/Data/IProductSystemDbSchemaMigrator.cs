using System.Threading.Tasks;

namespace ProductSystem.Data;

public interface IProductSystemDbSchemaMigrator
{
    Task MigrateAsync();
}
