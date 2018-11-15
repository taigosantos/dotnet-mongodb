using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LinqSpecs;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using NetCoreMongo.Web.Data.Context;
using NetCoreMongo.Web.Domain.Users;
using NetCoreMongo.Web.Domain.Users.Models;
using NetCoreMongo.Web.Domain.Users.Repository;
using NetCoreMongo.Web.Shared;
using NetCoreMongo.Web.Shared.Extensions;
using NetCoreMongo.Web.Shared.Specifications;

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

        public IEnumerable<UserItem> List(Expression<Func<User, bool>> predicate)
        {
            var userItem = _usersContext.Users
                .AsQueryable()
                .ActiveRegisters()
                .Where(predicate)
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