using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using LinqSpecs;
using NetCoreMongo.Web.Domain.Users.Models;

namespace NetCoreMongo.Web.Domain.Users.Specifications
{
    public class UsersFromProfession : Specification<User>
    {
        private readonly string _professionId;

        public UsersFromProfession(string professionId)
        {
            _professionId = professionId;
        }

        public override Expression<Func<User, bool>> ToExpression()
        {
            return user => user.Profession.Id == _professionId;
        }
    }
}
