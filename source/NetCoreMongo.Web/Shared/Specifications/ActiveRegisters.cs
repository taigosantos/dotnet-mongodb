using System;
using System.Linq.Expressions;
using LinqSpecs;

namespace NetCoreMongo.Web.Shared.Specifications
{
    public class ActiveRegisters<T> : Specification<T>
        where T : Entity
    {
        #region Override Methods

        public override Expression<Func<T, bool>> ToExpression()
        {
            return entity => entity.IsRemoved == false;
        }

        #endregion
    }
}