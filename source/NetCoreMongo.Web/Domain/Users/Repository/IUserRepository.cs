using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using NetCoreMongo.Web.Domain.Users.Models;

namespace NetCoreMongo.Web.Domain.Users.Repository
{
    public interface IUserRepository
    {
        #region Public Methods

        Task CreateUser(User user);
        Task<User> GetById(string userId);
        Task<IEnumerable<UserItem>> Find(Expression<Func<User, bool>> predicate);

        #endregion
    }
}