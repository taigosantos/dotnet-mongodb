using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDbTests.Api.Domain.Users;
using MongoDbTests.Api.Domain.Users.Repository;

namespace MongoDbTests.Api.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public bool CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
