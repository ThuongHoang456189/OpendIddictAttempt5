using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace OpendIddictAttempt4.Controllers.Anyone
{
    [ControllerName("Guest")]
    [Route("api/sras/guest-hello")]
    public class GuestController : AbpController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { data = "You guest" });
        }
    }
}
