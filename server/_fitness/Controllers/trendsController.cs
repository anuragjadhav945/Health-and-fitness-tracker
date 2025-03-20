using _fitness.dataContext;
using _fitness.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _fitness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class trendsController : ControllerBase
    {
        private readonly DbSet<Trend> _users;
        private readonly _dataContext _dbConnect;
        public trendsController(_dataContext context)
        {

            _dbConnect = context;
            _users = _dbConnect.Set<Trend>();
        }

        public async Task<ActionResult<string>> trendsCreation([FromBody] Trend _trend)
        {
            try
            {
                if (_trend != null)
                {
                    var rest = await _users.FirstOrDefaultAsync(x => x.UserId == _trend.UserId);
                    if (rest == null)
                    {
                        _users.AddAsync(_trend);
                        await _dbConnect.SaveChangesAsync();
                        return Ok("user ");
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
