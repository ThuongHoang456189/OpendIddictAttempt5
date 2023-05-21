using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace OpendIddictAttempt4.Controllers.Author
{
    [ControllerName("Author")]
    [Route("api/sras/author-hello")]
    public class AuthorController : AbpController
    {
        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            return Ok(new { data = "Hello Author. Work for better things" });
        }
    }
}
