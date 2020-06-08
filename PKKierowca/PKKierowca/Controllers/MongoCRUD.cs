using MongoDB.Bson;
using MongoDB.Driver;
using PKKierowca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PKKierowca.Controllers
{
    public class MongoCRUD
    {
        private IMongoDatabase db;
        //private IMongoCollection<Position> positionCollection;

        public MongoCRUD(string database)
        {
            var client = new MongoClient("mongodb+srv://adrian:adrian2020@pkcluster-3agdh.mongodb.net/test?retryWrites=true&w=majority");
            db = client.GetDatabase(database);
            //positionCollection = db.GetCollection<Position>("position");

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

        /********************************/

        public List<T> LoadRecordsbyPesel<T>(string table, string id)
        {
            var collection = db.GetCollection<T>(table);
            var Query = Builders<T>.Filter.Eq("pesel", id);
           

            return collection.Find(Query).ToList();

        }

        //
        public List<Position> DriversTrafficOffenders(string pesel)
        {
            var position = db.GetCollection<Position>("Position");
            var builder = Builders<Position>.Filter;
            var filter = builder.Gt("speed", 50) & builder.Eq("pesel", pesel) ;

             
            return position.Find(filter).ToList();

        }
        public List<Position> DriversTrafficOffendersDate(string pesel)
        {
            var position = db.GetCollection<Position>("Position");
            var today = DateTime.Today;
            var month = new DateTime(today.Year, today.Month, 1);
            var lastMonth = month.AddMonths(-1);
          // var lastMonth = DateTime.SpecifyKind(first, DateTimeKind.Utc);
            var builder = Builders<Position>.Filter;
            var filter = builder.Gt("speed", 50) & builder.Eq("pesel", pesel) & builder.Gte("date",new BsonDateTime(lastMonth)) ;

            return position.Find(filter).ToList();
        }
     
      
        /// ///////////////////////////////////////////////
 

        public List<T> LoadRecordsbyRn<T>(string table, string rn)
        {
            var collection = db.GetCollection<T>(table);
            var Query = Builders<T>.Filter.Eq("rn", rn);


            return collection.Find(Query).ToList();

        }
        public List<Position> CarsTrafficOffenders(string rn)
        {
            var position = db.GetCollection<Position>("Position");
            var builder = Builders<Position>.Filter;
            var filter = builder.Gt("speed", 50) & builder.Eq("rn", rn);


            return position.Find(filter).ToList();

        }
        public List<Position> CarsTrafficOffendersDate(string rn)
        {
            var position = db.GetCollection<Position>("Position");
            var today = DateTime.Today;
            var month = new DateTime(today.Year, today.Month, 1);
            var lastMonth = month.AddMonths(-1);
            var builder = Builders<Position>.Filter;

            var filter = builder.Gt("speed", 50) & builder.Eq("rn", rn) & builder.Gte("date", new BsonDateTime(lastMonth));

            return position.Find(filter).ToList();
        }

    }
}