using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTBD.Db
{
    public sealed class MongoDBClient : IDbManager
    {
        private static MongoDBClient _mongoDbClient;
        private IMongoClient _client;
        private IMongoDatabase _database;
        private static object _lock = new object();


        private MongoDBClient()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("ZTBD");
        }

        public static MongoDBClient MongoDbClient
        {
            get
            {
                lock (_lock)
                {
                    if (_mongoDbClient == null)
                    {
                        _mongoDbClient = new MongoDBClient();
                    }
                    return _mongoDbClient;
                }
            }
        }


        public async void InsertData(Data d)
        {
            var collection = _database.GetCollection<BsonDocument>("test");
            await collection.InsertOneAsync(d.ToBsonDocument());
        }

        public List<Data> GetData()
        {
            var filter = new BsonDocument();
            var collection = _database.GetCollection<Data>("test");
            var a = collection.Find(filter).ToList();
            
            //var b = BsonSerializer.Deserialize<List<Data>>(a);
            return a;
        }
    }
}
