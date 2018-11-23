using System;
using System.Linq.Expressions;
using LinqSpecs;

namespace NetCoreMongo.Web.Domain.Users.Specifications
{
    public class UsersFromCountry : Specification<User>
    {
        #region Fields

        private readonly string _countryId;

        #endregion

        #region Constructors

        public UsersFromCountry(string countryId)
        {
            _countryId = countryId;
        }

        #endregion

        #region Override Methods

        public override Expression<Func<User, bool>> ToExpression()
        {
            return user => user.Country.Id == _countryId;
        }

        #endregion
    }
}