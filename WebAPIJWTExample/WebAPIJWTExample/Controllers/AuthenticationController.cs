using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebAPIJWTExample.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIJWTExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
       
        [HttpPost]
        public IActionResult Post([FromBody] Login user)
        {
            if(user == null)
            {
                return BadRequest("Invalid Request hint: Please provide Credential");
            }
            else
            {
                if((user.UserName=="sam")&&(user.Password=="sam@1256"))
                {
                    var secretKey=new SymmetricSecurityKey(Encoding.UTF8.GetBytes("deb3f0527168d944daa45659c6bf808f"));
                    var siginCredentials=new  SigningCredentials(secretKey,SecurityAlgorithms.HmacSha256);
                    var tokenOptions = new JwtSecurityToken(
                        issuer: "https://localhost:5001",
                        audience: "https://localhost:5001",
                        claims: new List<Claim>(),
                        expires:DateTime.Now.AddMinutes(5),
                        signingCredentials: siginCredentials
                        );
                    var tokenString=new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                    return Ok( new AuthenticateResponse { Token=tokenString} );
                }
               
            }
            return Unauthorized();
        }

        
    }
}
