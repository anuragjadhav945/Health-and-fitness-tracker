using _fitness.dataContext;
using _fitness.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _fitness.Controllers
{
    [ApiController]
    
    [Route("api/[controller]")]
    public class userController : ControllerBase
    {
        private readonly DbSet<users> _users;
        private readonly _dataContext _dbConnect;
        public userController(_dataContext context)
        {
            _dbConnect = context;
            _users = _dbConnect.Set<users>();
        }

        [HttpPost("senddata")]

        public async Task<ActionResult<string>> usercrate([FromBody]  users _dt)
        {
            try
            {
                if (_dt != null)
                {
                    await _users.AddAsync(_dt);
                    await _dbConnect.SaveChangesAsync();
                    return Ok("userCreated");
                }
                else
                {
                    return BadRequest("Not Allowed");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [Authorize]
        [HttpDelete]
        public async Task<ActionResult<string>> deleteuser( int _dt)
        {
            try
            {
                if (_dt != null  && _dt !=0)
                {
                    var rest = await _users.FirstOrDefaultAsync(x => x.Id == _dt);
                    if (rest != null)
                    {
                         _users.Remove(rest);
                        await _dbConnect.SaveChangesAsync();
                        return Ok("user Deteled");
                    }
                    else
                    {
                        return Ok("user not Avail");
                    }
                }
                else
                {
                    return BadRequest("Not Allowed");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

     


    }
}
