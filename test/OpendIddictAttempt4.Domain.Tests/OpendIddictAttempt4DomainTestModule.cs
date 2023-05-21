using OpendIddictAttempt4.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace OpendIddictAttempt4;

[DependsOn(
    typeof(OpendIddictAttempt4EntityFrameworkCoreTestModule)
    )]
public class OpendIddictAttempt4DomainTestModule : AbpModule
{

}
