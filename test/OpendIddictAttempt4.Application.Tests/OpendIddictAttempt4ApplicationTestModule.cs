using Volo.Abp.Modularity;

namespace OpendIddictAttempt4;

[DependsOn(
    typeof(OpendIddictAttempt4ApplicationModule),
    typeof(OpendIddictAttempt4DomainTestModule)
    )]
public class OpendIddictAttempt4ApplicationTestModule : AbpModule
{

}
