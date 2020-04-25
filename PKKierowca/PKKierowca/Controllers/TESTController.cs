using MongoDB.Bson.Serialization.Attributes;
using PKKierowca.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace PKKierowca.Controllers
{
    public class TESTController : ApiController
    {
    
        MongoCRUD db = new MongoCRUD("PKDriver");
        /******************CARS********************/
        
        [Route("API/TEST/Cars")]
        [HttpGet]
        public List<Cars> GetCars()
        {
            // var a = db.LoadRecords<Addresses>("Addresses");
            return db.LoadRecords<Cars>("Cars");
        }

        [Route("API/TEST/Cars/{Id}")]
        [HttpGet]
        public Cars GetCarsById(string Id)
        {
            return db.LoadRecordsbyId<Cars>("Cars", Id);
        }


        /*****************ADDRESSES****************/
        [Route("API/TEST/Addresses")]
        [HttpGet]
        public List<Addresses> GetAddresses()
        {
            // var a = db.LoadRecords<Addresses>("Addresses");
            return db.LoadRecords<Addresses>("Addresses");
        }

        [Route("API/TEST/Addresses/{Id}")]
        [HttpGet]
        public Addresses GetAddressesId(string Id)
        {
            return db.LoadRecordsbyId<Addresses>("Addresses", Id);
        }

        /******************DRIVERS*****************/

        [Route("API/TEST/Drivers")]
        [HttpGet]
        public List<Drivers> GetDrivers()
        {
            // var a = db.LoadRecords<Addresses>("Addresses");
            return db.LoadRecords<Drivers>("Drivers");
        }
        //
        [Route("API/TEST/Drivers/{Id}")]
        [HttpGet]
        public Drivers GetDriversById(string table, string Id)
        {
            return db.LoadRecordsbyId<Drivers>("Drivers", Id);
        }
        /***************POSITON********************/
        [Route("API/TEST/Position")]
        [HttpGet]
        public List<Position> GetPosition()
        {
            // var a = db.LoadRecords<Addresses>("Addresses");
            return db.LoadRecords<Position>("Position");
        }

        [Route("API/TEST/Position/{Id}")]
        [HttpGet]
        public Position GetPositionById(string Id)
        {
            return db.LoadRecordsbyId<Position>("Position", Id);
        }
        /*********************************
   public class Addresses
   {
       [BsonRepresentation(BsonType.ObjectId)]
       public string id { get; set; }
       public int pos_x { get; set; }
       public int pos_y { get; set; }
       public string address { get; set; }
   }
   public class Cars
   {
       [BsonRepresentation(BsonType.ObjectId)]
       public string _id { get; set; }

       public string vendor { get; set; }

       public string model { get; set; }

       public string line { get; set; }

       public double capacity { get; set; }

       public int KMage { get; set; }

       public string rn { get; set; }

   }
   public class Drivers
   {
       [BsonRepresentation(BsonType.ObjectId)]
       public string id { get; set; }
       public string name { get; set; }
       public string lastname { get; set; }
       public DateTime born { get; set; }
       public string adress { get; set; }
       public string profession { get; set; }

   }
   public class Position
   {
       [BsonRepresentation(BsonType.ObjectId)]
       public string _id { get; set; }
       public int pos_x { get; set; }

       public int pos_y { get; set; }

       public string rn { get; set; }

       public string pesel { get; set; }

       public int speed { get; set; }

       public DateTime date { get; set; }

   }
   */
    }
}
