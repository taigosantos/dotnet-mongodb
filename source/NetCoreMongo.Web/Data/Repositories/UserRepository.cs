using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreMongoDb.Web.Data.Context;
using AspNetCoreMongoDb.Web.Domain.Users;
using AspNetCoreMongoDb.Web.Domain.Users.Models;
using AspNetCoreMongoDb.Web.Domain.Users.Repository;
using MongoDB.Driver;

namespace AspNetCoreMongoDb.Web.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UsersContext _usersContext;

        public UserRepository(UsersContext usersContext)
        {
            _usersContext = usersContext;
        }

        public void CreateUser(User user)
        {
            _usersContext.Users.InsertOne(user);
        }

        public User GetById(Guid userId)
        {
            var user = _usersContext.Users.AsQueryable().FirstOrDefault(x => x.Id == userId);
            return user;
        }

        public IEnumerable<UserItem> List()
        {
            var userItem = _usersContext
                .Users
                .AsQueryable()
                .Join(_usersContext.Professions.AsQueryable(), 
                    u => u.ProfessionId, 
                    p => p.Id, 
                    (u, p) => new
                    {
                        u.Id,
                        u.Name,
                        u.CountryId,
                        Profession = p.Desription
                    })
                .Join(_usersContext.Countries.AsQueryable(),
                    u => u.CountryId,
                    c => c.Id,
                    (u, c) => new
                    {
                        u.Id,
                        u.Name,
                        u.Profession,
                        Country = c.Desription
                    })
                .Select(u => new UserItem
                {
                    Id = u.Id,
                    Name = u.Name,
                    Profission = u.Profession,
                    Country = u.Country
                });

            return userItem;
        }
    }
}
