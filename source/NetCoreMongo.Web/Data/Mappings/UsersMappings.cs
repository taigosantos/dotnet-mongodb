using MongoDB.Bson.Serialization;
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
                map.MapField(fieldName: "_emails").SetElementName(elementName: "Emails");
            });
        }

        #endregion
    }
}