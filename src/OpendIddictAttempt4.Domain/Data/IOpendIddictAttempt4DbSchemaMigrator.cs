using System.Threading.Tasks;

namespace OpendIddictAttempt4.Data;

public interface IOpendIddictAttempt4DbSchemaMigrator
{
    Task MigrateAsync();
}
