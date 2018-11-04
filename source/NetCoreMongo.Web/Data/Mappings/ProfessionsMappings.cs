using MongoDB.Bson.Serialization;
using NetCoreMongo.Web.Domain.Professions;

namespace NetCoreMongo.Web.Data.Mappings
{
    public static class ProfessionsMappings
    {
        #region Public Methods

        public static void RegisterProfessionsMappings()
        {
            BsonClassMap.RegisterClassMap<Profession>(map =>
            {
                map.AutoMap();
            });
        }

        #endregion
    }
}