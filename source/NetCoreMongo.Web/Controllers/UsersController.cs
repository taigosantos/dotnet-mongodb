using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreMongo.Web.Domain.Countries;
using NetCoreMongo.Web.Domain.Professions;
using NetCoreMongo.Web.Domain.Users;
using NetCoreMongo.Web.Domain.Users.Commands;
using NetCoreMongo.Web.Domain.Users.Models;
using NetCoreMongo.Web.Domain.Users.Repository;
using NetCoreMongo.Web.Domain.Users.Specifications;

namespace NetCoreMongo.Web.Controllers
{
    [Route("api/users")]
    public class UsersController : Controller
    {
        #region Fields

        private readonly IUserRepository _userRepository;

        #endregion

        #region Constructors

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        #endregion

        #region Public Methods

        [HttpGet]
        public async Task<IActionResult> FindUsers(UserParameters parameters)
        {
            // Get from repository

            var usersList = await _userRepository.Find(parameters.ToExpression());

            // Return 'Ok' with the userList

            return Ok(usersList);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUser createUser)
        {
            // Mapping

            var user = new User(
                name: createUser.Name,
                profession: new Profession(
                    id: createUser.ProfessionId,
                    description: createUser.Profession
                    ), 
                country: new Country(
                    id: createUser.CountryId,
                    description: createUser.Country
                    )
                );

            foreach (var email in createUser.Emails)
            {
                user.AddEmail(email.Address);
            }

            // Create in repository

            await _userRepository.CreateUser(user);

            // Return Created

            return Created($"api/users/{user.Id}", user);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserById(string userId)
        {
            // Get from repository

            var user = await _userRepository.GetById(userId);

            // Return 'Not Found' if null

            if (user == null)
            {
                return NotFound();
            }

            // Return 'Ok' with the user

            return Ok(user);
        }

        #endregion
    }
}