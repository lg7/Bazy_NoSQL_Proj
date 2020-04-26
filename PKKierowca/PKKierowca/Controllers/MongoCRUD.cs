using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PKKierowca.Controllers
{
    public class MongoCRUD
    {
        private IMongoDatabase db;

        public MongoCRUD(string database)
        {
            var client = new MongoClient("mongodb+srv://adrian:adrian2020@pkcluster-3agdh.mongodb.net/test?retryWrites=true&w=majority");
            db = client.GetDatabase(database);
        }

        public MongoCRUD(IMongoDatabase db)
        {
            this.db = db;
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }

        public T LoadRecordsbyId<T>(string table, string ID)
        {
            var collection = db.GetCollection<T>(table);
            var Query = Builders<T>.Filter.Eq("id", ID);
            return collection.Find(Query).First();
        }
        public void InsertData<T>(string table, T data)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(data);
        }

        public void DeleteRecord<T>(string table, string ID)
        {
            var collection = db.GetCollection<T>(table);
            var Query = Builders<T>.Filter.Eq("id", ID);
            collection.DeleteOne(Query);
        }
        public void UpdateRecord<T>(string table, string ID, T data)
        {
            var collection = db.GetCollection<T>(table);
            var Query = Builders<T>.Filter.Eq("id", ID);

            var result = collection.ReplaceOne(Query, data);

        }
    }
}