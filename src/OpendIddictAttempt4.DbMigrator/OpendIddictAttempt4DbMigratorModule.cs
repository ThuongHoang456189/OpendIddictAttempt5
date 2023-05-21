using OpendIddictAttempt4.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace OpendIddictAttempt4.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(OpendIddictAttempt4EntityFrameworkCoreModule),
    typeof(OpendIddictAttempt4ApplicationContractsModule)
    )]
public class OpendIddictAttempt4DbMigratorModule : AbpModule
{

}
