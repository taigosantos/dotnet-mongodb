using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using LinqSpecs;

namespace NetCoreMongo.Web.Domain.Users.Specifications
{
    public class UsersFromCountry : Specification<User>
    {
        private string _countryId;

        public UsersFromCountry(string countryId)
        {
            _countryId = countryId;
        }

        public override Expression<Func<User, bool>> ToExpression()
        {
            return user => user.CountryId == _countryId;
        }
    }
}
