using MongoDB.Driver.Linq;
using NetCoreMongo.Web.Shared.Specifications;

namespace NetCoreMongo.Web.Shared.Extensions
{
    public static class MongoQueryableExtensions
    {
        public static IMongoQueryable<T> ActiveRegisters<T>(this IMongoQueryable<T> queriable)
            where T : Entity
        {
            return queriable.Where(new ActiveRegisters<T>());
        }
    }
}