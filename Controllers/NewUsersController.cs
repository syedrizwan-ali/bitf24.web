using FCIT.BITF24A.Web.DB_Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FCIT.BITF24A.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewUsersController : ControllerBase
    {
        private readonly Bitf24aDbContext _dbContext;
        public NewUsersController(Bitf24aDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet, Route("Health")]
        public bool Health() => true;

        [HttpGet, Route("Login")]
        public string Login(string username, string password)
        {
            var userCount = _dbContext.Users.
                Where(x => x.Username == username
                && x.Password == password)
                .Count();

            if (userCount > 0)
            {
                return "Authenticated";
            }
            else
            {
                return "Invalid User";
            }
        }
    }
}


