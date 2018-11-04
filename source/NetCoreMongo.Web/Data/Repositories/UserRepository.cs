using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using NetCoreMongo.Web.Data.Context;
using NetCoreMongo.Web.Domain.Users;
using NetCoreMongo.Web.Domain.Users.Models;
using NetCoreMongo.Web.Domain.Users.Repository;

namespace NetCoreMongo.Web.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        #region Fields

        private readonly UsersContext _usersContext;

        #endregion

        #region Constructors

        public UserRepository(UsersContext usersContext)
        {
            _usersContext = usersContext;
        }

        #endregion

        #region Implementations

        public void CreateUser(User user)
        {
            _usersContext.Users.InsertOne(user);
        }

        public User GetById(string userId)
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
                    Profission = u.Profession.Description,
                    Country = u.Country.Description
                })
                .ToList();

            return userItem;
        }

        #endregion
    }
}