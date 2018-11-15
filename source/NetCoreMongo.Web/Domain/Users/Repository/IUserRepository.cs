using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using NetCoreMongo.Web.Domain.Users.Models;

namespace NetCoreMongo.Web.Domain.Users.Repository
{
    public interface IUserRepository
    {
        #region Public Methods

        void CreateUser(User user);
        User GetById(string userId);
        IEnumerable<UserItem> List(Expression<Func<User, bool>> predicate);

        #endregion
    }
}