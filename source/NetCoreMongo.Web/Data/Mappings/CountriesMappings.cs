using AspNetCoreMongoDb.Web.Domain.Countries;
using MongoDB.Bson.Serialization;

namespace AspNetCoreMongoDb.Web.Data.Mappings
{
    public static class CountriesMappings
    {
        public static void RegisterCountriesMappings()
        {
            BsonClassMap.RegisterClassMap<Country>(map =>
            {
                map.AutoMap();
            });
        }
    }
}
