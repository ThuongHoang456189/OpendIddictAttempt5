using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OpendIddictAttempt4.Data;
using Volo.Abp.DependencyInjection;

namespace OpendIddictAttempt4.EntityFrameworkCore;

public class EntityFrameworkCoreOpendIddictAttempt4DbSchemaMigrator
    : IOpendIddictAttempt4DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreOpendIddictAttempt4DbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the OpendIddictAttempt4DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<OpendIddictAttempt4DbContext>()
            .Database
            .MigrateAsync();
    }
}
