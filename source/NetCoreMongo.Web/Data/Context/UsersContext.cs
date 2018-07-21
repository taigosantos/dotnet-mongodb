using System;
using AspNetCoreMongoDb.Web.Domain.Countries;
using AspNetCoreMongoDb.Web.Domain.Professions;
using AspNetCoreMongoDb.Web.Domain.Users;
using MongoDB.Driver;

namespace AspNetCoreMongoDb.Web.Data.Context
{
    public class UsersContext
    {
        private readonly IMongoDatabase _database;

        public UsersContext(IMongoDatabase database)
        {
            _database = database;
        }

        public IMongoCollection<User> Users => _database.GetCollection<User>("Users");
        public IMongoCollection<Profession> Professions => _database.GetCollection<Profession>("Professions");
        public IMongoCollection<Country> Countries => _database.GetCollection<Country>("Countries");
    }
}
