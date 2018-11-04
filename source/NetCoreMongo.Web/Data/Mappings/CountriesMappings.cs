using MongoDB.Bson.Serialization;
using NetCoreMongo.Web.Domain.Countries;

namespace NetCoreMongo.Web.Data.Mappings
{
    public static class CountriesMappings
    {
        #region Public Methods

        public static void RegisterCountriesMappings()
        {
            BsonClassMap.RegisterClassMap<Country>(map =>
            {
                map.AutoMap();
            });
        }

        #endregion
    }
}