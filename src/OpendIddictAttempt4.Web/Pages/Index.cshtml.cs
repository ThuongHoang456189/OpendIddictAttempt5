using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace OpendIddictAttempt4.Web.Pages;

public class IndexModel : OpendIddictAttempt4PageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
