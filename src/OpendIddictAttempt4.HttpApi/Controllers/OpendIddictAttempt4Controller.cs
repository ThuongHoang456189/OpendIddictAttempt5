using OpendIddictAttempt4.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace OpendIddictAttempt4.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class OpendIddictAttempt4Controller : AbpControllerBase
{
    protected OpendIddictAttempt4Controller()
    {
        LocalizationResource = typeof(OpendIddictAttempt4Resource);
    }
}
