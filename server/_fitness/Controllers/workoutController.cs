using _fitness.dataContext;
using _fitness.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _fitness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    private readonly DbSet<Workout> _users;
    private readonly _dataContext _dbConnect;
    public class workoutController : ControllerBase
    {
        public workoutController(_dataContext context)
        {
            _dbConnect = context;
            _users = _dbConnect.Set<Trend>();
        }

        public async Task<ActionResult<string>> trendsCreation([FromBody] Workout _trend)
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
                        return Ok("Workout Logged");
                    }
                    else
                    {
                        return Ok("Workout not logged");
                    }
                }
                else
                {
                    return BadRequest("workout not logged");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
