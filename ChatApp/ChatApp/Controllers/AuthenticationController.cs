﻿using ChatApp.Models.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        public async Task<AuthenticationDTO> doAuthen()
        {
            return new AuthenticationDTO();
        }
    }
}
