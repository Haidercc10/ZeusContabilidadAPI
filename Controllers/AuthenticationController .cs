﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ContabilidadZeusAPI.Service;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ConfigurationManager = ContabilidadZeusAPI.Service.ConfigurationManager;
using DBInventarioZeusAPI.Models;

namespace ContabilidadZeusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ContabilidadContext _context;
        public AuthenticationController(ContabilidadContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] Login user)
        {
            if (user is null)
            {
                return BadRequest("Invalid user request!!!");
            }
            if (user.Id_Usuario == 123456987 && user.Contrasena == "123456987")
            {
#pragma warning disable CS8604 // Posible argumento de referencia nulo
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(ConfigurationManager.AppSetting["JWT:Secret"]));
#pragma warning restore CS8604 // Posible argumento de referencia nulo
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokeOptions = new JwtSecurityToken(
                    issuer: ConfigurationManager.AppSetting["JWT:ValidIssuer"],
                    audience: ConfigurationManager.AppSetting["JWT:ValidAudience"],
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddHours(24),
                    signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new JWTTokenResponse { 
                    Usuario = "Admin",
                    Token = tokenString 
                });
            }
            return Unauthorized();
        }
    }
}
