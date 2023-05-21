﻿using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace OpendIddictAttempt4.Controllers.Chair
{
    [ControllerName("Chair")]
    [Route("api/sras/chair-hello")]
    public class ChairController : AbpController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { data = "Hello Chair. Work for better things" });
        }
    }
}