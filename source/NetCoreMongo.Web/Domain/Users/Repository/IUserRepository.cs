using System;
using System.Collections.Generic;
using AspNetCoreMongoDb.Web.Domain.Users;
using AspNetCoreMongoDb.Web.Domain.Users.Models;

namespace AspNetCoreMongoDb.Web.Domain.Users.Repository
{
    public interface IUserRepository
    {
        void CreateUser(User user);
        User GetById(Guid userId);
        IEnumerable<UserItem> List();
    }
}