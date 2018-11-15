using System;
using System.Linq.Expressions;
using LinqSpecs;
using NetCoreMongo.Web.Domain.Users.Specifications;
using NetCoreMongo.Web.Shared;

namespace NetCoreMongo.Web.Domain.Users.Models
{
    public class UserParameters
    {
        #region Properties

        public string Query { get; set; }
        public string CountryId { get; set; }
        public string ProfessionId { get; set; }

        #endregion

        #region Public Methods

        public Expression<Func<User, bool>> ToExpression()
        {
            Specification<User> query = new TrueSpecification<User>();

            if (!string.IsNullOrWhiteSpace(CountryId))
            {
                query &= new UsersFromCountry(CountryId);
            }

            if (!string.IsNullOrWhiteSpace(ProfessionId))
            {
                query &= new UsersFromProfession(ProfessionId);
            }
            return query;
        }

        #endregion
    }
}