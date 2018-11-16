using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using NetCoreMongo.Web.Data.Context;
using NetCoreMongo.Web.Domain.Users;
using NetCoreMongo.Web.Domain.Users.Models;
using NetCoreMongo.Web.Domain.Users.Repository;
using NetCoreMongo.Web.Shared.Extensions;

namespace NetCoreMongo.Web.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        #region Fields

        private readonly IMongoCollection<User> _users;

        #endregion

        #region Constructors

        public UserRepository(UsersContext usersContext)
        {
            _users = usersContext.Users;
        }

        #endregion

        #region Implementations

        public async Task CreateUser(User user)
        {
            await _users.InsertOneAsync(user);
        }

        public async Task<User> GetById(string userId)
        {
            return await _users.AsQueryable().FirstOrDefaultAsync(x => x.Id == userId);
        }

        public async Task<IEnumerable<UserItem>> Find(Expression<Func<User, bool>> predicate)
        {
            return await _users
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
                .ToListAsync();
        }

        #endregion
    }
}