using OpendIddictAttempt4.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace OpendIddictAttempt4.Web.Pages;

public abstract class OpendIddictAttempt4PageModel : AbpPageModel
{
    protected OpendIddictAttempt4PageModel()
    {
        LocalizationResourceType = typeof(OpendIddictAttempt4Resource);
    }
}
