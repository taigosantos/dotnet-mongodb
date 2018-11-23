using MongoDB.Driver.Linq;
using NetCoreMongo.Web.Shared.Specifications;

namespace NetCoreMongo.Web.Shared.Extensions
{
    public static class MongoQueryableExtensions
    {
        #region Public Methods

        public static IMongoQueryable<T> ActiveRegisters<T>(this IMongoQueryable<T> queryable)
            where T : Entity
        {
            return queryable.Where(new ActiveRegisters<T>());
        }

        #endregion
    }
}