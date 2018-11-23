using System;
using System.Linq.Expressions;
using LinqSpecs;

namespace NetCoreMongo.Web.Domain.Users.Specifications
{
    public class UsersFromProfession : Specification<User>
    {
        #region Fields

        private readonly string _professionId;

        #endregion

        #region Constructors

        public UsersFromProfession(string professionId)
        {
            _professionId = professionId;
        }

        #endregion

        #region Override Methods

        public override Expression<Func<User, bool>> ToExpression()
        {
            return user => user.Profession.Id == _professionId;
        }

        #endregion
    }
}