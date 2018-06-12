using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbTests.Configurations
{
    public static class MongoConfigurations
    {
        public const string ConnectionString = "mongodb://dotnetcore-mongo.db/?safe=true&uuidRepresentation=Standard";
        public const string Database = "dotnetcoreTestsDb";
    }
}
