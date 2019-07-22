using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbConsoleApp
{


    public class MongoService
    {
        private readonly string connectionString = "mongodb://localhost:27017";

        private readonly MongoClient client;

        private readonly IMongoDatabase database;

        private readonly IMongoCollection<Symbol> collection;

        public MongoService()
        {
            client = new MongoClient(connectionString);
            database = client.GetDatabase("Kailash");
            //database.DropCollection("Symbols1");
            collection = database.GetCollection<Symbol>("Symbols1");
        }

        public IList<T> GetBsonElements<T>(string collectionName, string filter = "", string sort = "", string projection = "")
        {
            if (string.IsNullOrEmpty(filter))
            {
                return GetBsonElements<T>(collectionName, sort, projection);
            }
            return database.GetCollection<T>(collectionName)
                .Find(BsonDocument.Parse(filter))
                .Sort(BsonDocument.Parse(sort))
                .Project<T>(BsonDocument.Parse(projection))
                .ToList();
        }

        private IList<T> GetBsonElements<T>(string collectionName, string sort, string projection)
        {
            if (string.IsNullOrEmpty(sort))
            {
                return GetBsonElements<T>(collectionName, projection);
            }
            return database.GetCollection<T>(collectionName)
                .Find(new BsonDocument())
                .Sort(BsonDocument.Parse(sort))
                .Project<T>(BsonDocument.Parse(projection))
                .ToList();
        }

        private IList<T> GetBsonElements<T>(string collectionName, string projection)
        {
            if (string.IsNullOrEmpty(projection))
            {
                return database.GetCollection<T>(collectionName)
                    .Find(new BsonDocument())
                    .ToList();
            }
            return database.GetCollection<T>(collectionName)
                .Find(new BsonDocument())
                .Project<T>(BsonDocument.Parse(projection))
                .ToList();
        }

        public IMongoCollection<Symbol> Collection => collection;
    }
}
