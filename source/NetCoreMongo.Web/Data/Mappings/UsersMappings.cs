using AspNetCoreMongoDb.Web.Domain.Users;
using MongoDB.Bson.Serialization;

namespace AspNetCoreMongoDb.Web.Data.Mappings
{
    public static class UsersMappings
    {
        public static void RegisterUsersMappings()
        {
            BsonClassMap.RegisterClassMap<User>(map =>
            {
                map.AutoMap();

                map.MapField(fieldName: "_emails").SetElementName(elementName: "Emails");
            });
        }
    }
}
