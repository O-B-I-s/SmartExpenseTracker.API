using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SmartExpenseTracker.API.Data;
using SmartExpenseTracker.API.DTOs;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SmartExpenseTracker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;


        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var roles = await _userManager.GetRolesAsync(user);
                var authClaims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.UserName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

                foreach (var role in roles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, role));
                }

                var token = new JwtSecurityToken(
                    issuer: "https://localhost:7011",
                    audience: "http://localhost:4200/",
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(
                        new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MySuperSecretKeyThatIsLongEnoughForHS256")),
                        SecurityAlgorithms.HmacSha256)
                );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }

            return Unauthorized();
        }


        [HttpPost("register")]
        public async Task<ActionResult<ApplicationUser>> Register(RegisterDTO dto)
        {
            var existingUser = await _userManager.FindByNameAsync(dto.Username);
            if (existingUser != null)
                return BadRequest("Username already exists");
            existingUser = await _userManager.FindByEmailAsync(dto.Email);
            if (existingUser != null)
                return BadRequest("Email already registered");

            var user = new ApplicationUser
            {

                UserName = dto.Username,
                Email = dto.Email,
                PersonName = dto.Username,
                EmailConfirmed = true

            };

            var result = await _userManager.CreateAsync(user, dto.Password);
            return Ok(result);
        }
        [HttpGet("getusers")]
        public async Task<IEnumerable<ApplicationUser>> GetAllUsers()
        {
            return await _userManager.Users.ToListAsync();
        }

    }
}
