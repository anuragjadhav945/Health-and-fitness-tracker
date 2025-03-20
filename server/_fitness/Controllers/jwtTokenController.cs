using _fitness.dataContext;
using _fitness.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace _fitness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class jwtTokenController : ControllerBase
    {

        private readonly DbSet<users> _users;
        private readonly _dataContext _dbConnect;
        private readonly IConfiguration _configure;
        public jwtTokenController(_dataContext context, IConfiguration config)
        {
            _dbConnect = context;
            _users = _dbConnect.Set<users>();
            _configure = config;
        }

        [HttpPost]
        public async Task<ActionResult<string>> cratetoken([FromBody] users _dt)
        {
            if (_dt.Email != null && _dt.Password != null)
            {
                var check = await _users.Where(x => x.Email == _dt.Email).ToListAsync();

                if (check[0].Email == _dt.Email && check[].Password == _dt.Password)
                {
                    var tokenkey = Encoding.ASCII.GetBytes(_configure.GetValue<string>("tokenValue"));

                    var tokenheader = new JwtSecurityTokenHandler();
                    var tokenDecript = new SecurityTokenDescriptor()
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                            new Claim(ClaimTypes.Email, _dt.Email)
                        }),
                        Expires = DateTime.UtcNow.AddMinutes(1),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenkey), SecurityAlgorithms.HmacSha256)
                    };

                    var _create = tokenheader.CreateToken(tokenDecript);
                    var _writeToken = tokenheader.WriteToken(_create);

                    return _writeToken;
                   }
                else
                {
                    return NotFound(" User Not found");
                }


             }
                else
                {
                    return NotFound("User not found");
                }
            
        }
    }
}
