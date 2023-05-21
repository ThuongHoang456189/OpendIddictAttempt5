using System;
using System.Collections.Generic;
using System.Text;
using OpendIddictAttempt4.Localization;
using Volo.Abp.Application.Services;

namespace OpendIddictAttempt4;

/* Inherit your application services from this class.
 */
public abstract class OpendIddictAttempt4AppService : ApplicationService
{
    protected OpendIddictAttempt4AppService()
    {
        LocalizationResource = typeof(OpendIddictAttempt4Resource);
    }
}
