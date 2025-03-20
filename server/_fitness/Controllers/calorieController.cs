using _fitness.dataContext;
using _fitness.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _fitness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class calorieController : ControllerBase
    {
        private readonly DbSet<Calorie> _users;
        private readonly _dataContext _dbConnect;
        public calorieController(_dataContext context)
        {
            _dbConnect = context;
            _users = _dbConnect.Set<Calorie>();
        }

        public async Task<ActionResult<string>> trendsCreation([FromBody] Calorie _trend)
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
                        return Ok("Calorie updated ");
                    }
                    else
                    {
                        return Ok("Calorie not updated");
                    }
                }
                else
                {
                    return BadRequest("Calorie not updated");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
