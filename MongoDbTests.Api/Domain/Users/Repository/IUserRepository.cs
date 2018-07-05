using System;

namespace MongoDbTests.Api.Domain.Users.Repository
{
    public interface IUserRepository
    {
        bool CreateUser(User user);
        bool UpdateUser(User user);
        User GetUserById(Guid userId);
    }
}