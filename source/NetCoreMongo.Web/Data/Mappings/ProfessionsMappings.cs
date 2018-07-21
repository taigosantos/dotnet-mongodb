using AspNetCoreMongoDb.Web.Domain.Professions;
using MongoDB.Bson.Serialization;

namespace AspNetCoreMongoDb.Web.Data.Mappings
{
    public static class ProfessionsMappings
    {
        public static void RegisterProfessionsMappings()
        {
            BsonClassMap.RegisterClassMap<Profession>(map =>
            {
                map.AutoMap();
            });
        }
    }
}
