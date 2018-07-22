using System;
using System.Linq.Expressions;
using AspNetCoreMongoDb.Web.Domain.Users;
using NetCoreMongo.Web.Utils;

namespace NetCoreMongo.Web.Domain.Users.Models
{
    public class UserParameters
    {
        public string Query { get; set; }
        public Guid? CountryId { get; set; }
        public Guid? ProfessionId { get; set; }

        public Expression<Func<User, bool>> ToExpression()
        {
            var predicate = PredicateBuilder.True<User>();

            //if (!string.IsNullOrWhiteSpace(Query))
            //{
            //    predicate = predicate.And(p =>
            //        p.Identification.Contains(Query) ||
            //        p.Email.Contains(Query) ||
            //        p.Name.ToLower().Contains(Query));
            //}

            //if (EmpresaId.HasValue)
            //{
            //    predicate = predicate.And(p => p.EmpresaId == EmpresaId.Value);
            //}

            return predicate;
        }
    }
}
