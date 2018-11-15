using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using LinqSpecs;
using NetCoreMongo.Web.Domain.Users.Models;

namespace NetCoreMongo.Web.Domain.Users.Specifications
{
    public class UsersFromCountry : Specification<User>
    {
        private readonly string _countryId;

        public UsersFromCountry(string countryId)
        {
            _countryId = countryId;
        }

        public override Expression<Func<User, bool>> ToExpression()
        {
            return user => user.Country.Id == _countryId;
        }
    }
}
