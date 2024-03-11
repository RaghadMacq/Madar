using System.Threading.Tasks;

namespace Madar.Data;

public interface IMadarDbSchemaMigrator
{
    Task MigrateAsync();
}
