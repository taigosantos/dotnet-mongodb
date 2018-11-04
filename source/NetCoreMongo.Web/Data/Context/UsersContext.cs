using MongoDB.Driver;
using NetCoreMongo.Web.Domain.Countries;
using NetCoreMongo.Web.Domain.Professions;
using NetCoreMongo.Web.Domain.Users;

namespace NetCoreMongo.Web.Data.Context
{
    public class UsersContext
    {
        #region Fields

        private readonly IMongoDatabase _database;

        #endregion

        #region Constructors

        public UsersContext(IMongoDatabase database)
        {
            _database = database;
        }

        #endregion

        #region Properties

        public IMongoCollection<User> Users => _database.GetCollection<User>("Users");
        public IMongoCollection<Profession> Professions => _database.GetCollection<Profession>("Professions");
        public IMongoCollection<Country> Countries => _database.GetCollection<Country>("Countries");

        #endregion
    }
}