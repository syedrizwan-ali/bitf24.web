using FCIT.BITF24A.Web.DB_Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FCIT.BITF24A.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly Bitf24aDbContext _dbContext;

        public UsersController(Bitf24aDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet, Route("Health")]
        public bool Health() => true;

        [HttpGet, Route("Login")]
        public bool Login(string username, string password)
        {
            var doesExist = _dbContext.Users
                .Any(x => x.Username == username 
                && x.Password == password);
            
            return doesExist;
        }
    }
}
