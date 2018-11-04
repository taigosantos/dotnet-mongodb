using System;
using System.Linq.Expressions;
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

            return x => true;
        }

        #endregion
    }
}