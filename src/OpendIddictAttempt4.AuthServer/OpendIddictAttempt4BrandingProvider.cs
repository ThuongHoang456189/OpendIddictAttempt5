using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace OpendIddictAttempt4;

[Dependency(ReplaceServices = true)]
public class OpendIddictAttempt4BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "OpendIddictAttempt4";
}
