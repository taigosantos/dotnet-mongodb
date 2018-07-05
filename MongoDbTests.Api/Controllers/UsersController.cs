using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDbTests.Api.Domain.Users;
using MongoDbTests.Api.Domain.Users.Commands;

namespace MongoDbTests.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/users")]
    public class UsersController : Controller
    {
        [HttpPost]
        public IActionResult CreateUser([FromBody]CreateUser createUser)
        {
            var user = new User(createUser.Name);

            foreach (var userPhone in createUser.Phones)
            {
                user.AddPhone(userPhone.Ddd, userPhone.Number);
            }

            return Ok();
        }
    }
}