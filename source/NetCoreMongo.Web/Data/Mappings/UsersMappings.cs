using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;
using NetCoreMongo.Web.Domain.Users;

namespace NetCoreMongo.Web.Data.Mappings
{
    public static class EntityMappings
    {
        #region Public Methods

        public static void RegisterEntityMappings()
        {
            BsonClassMap.RegisterClassMap<User>(map =>
            {
                map.AutoMap();

                map.MapProperty(c => c.ProfessionId).SetSerializer(new StringSerializer(BsonType.ObjectId));
                map.MapProperty(c => c.CountryId).SetSerializer(new StringSerializer(BsonType.ObjectId));

                map.MapField(fieldName: "_emails").SetElementName(elementName: "Emails");
            });
        }

        #endregion
    }
}