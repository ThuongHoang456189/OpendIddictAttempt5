using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace OpendIddictAttempt4.Data;

/* This is used if database provider does't define
 * IOpendIddictAttempt4DbSchemaMigrator implementation.
 */
public class NullOpendIddictAttempt4DbSchemaMigrator : IOpendIddictAttempt4DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
