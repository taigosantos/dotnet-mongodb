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
            var query = from u in _usersContext.Users.AsQueryable()
                        join p in _usersContext.Professions.AsQueryable() on u.ProfessionId equals p.Id into profession
                        join c in _usersContext.Countries.AsQueryable() on u.CountryId equals c.Id into country
                        select new
                        {
                            u.Id,
                            u.Name,
                            u.CountryId,
                            Profession = profession.First(),
                            Country = country.First()
                        };

            var userItem = query
                .Select(u => new UserItem
                {
                    Id = u.Id,
                    Name = u.Name,
                    Profission = u.Profession.Desription,
                    Country = u.Country.Desription
                })
                .ToList();

            return userItem;
        }
    }
}
