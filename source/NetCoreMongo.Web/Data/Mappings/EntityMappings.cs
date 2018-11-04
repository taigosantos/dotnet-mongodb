using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;
using NetCoreMongo.Web.Domain.Users;
using NetCoreMongo.Web.Shared;

namespace NetCoreMongo.Web.Data.Mappings
{
    public static class UsersMappings
    {
        #region Public Methods

        public static void RegisterUsersMappings()
        {
            BsonClassMap.RegisterClassMap<Entity>(map =>
            {
                map.AutoMap();

                map.MapIdProperty(c => c.Id)
                    .SetIdGenerator(StringObjectIdGenerator.Instance)
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));
            });
        }

        #endregion
    }
}