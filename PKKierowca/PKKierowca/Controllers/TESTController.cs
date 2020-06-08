using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using PKKierowca.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            return db.LoadRecords<Cars>("Cars");
        }

        [Route("API/TEST/Cars/{Id}")]
        [HttpGet]
        public Cars GetCarsById(string Id)
        {
            return db.LoadRecordsbyId<Cars>("Cars", Id);
        }
        [Route("API/TEST/Cars")]
        [HttpPost]
        public string PostCars([FromBody]Cars data)
        {
            db.InsertData("Cars", data);
            return "succes";
        }

        [Route("API/TEST/Cars/{Id}")]
        [HttpDelete]
        public string DeleteCars(string Id)
        {
            db.DeleteRecord<Cars>("Cars", Id);
            return "delete record " + Id;
        }
        [Route("API/TEST/Cars/Update/{Id}")]
        [HttpPut]
        public string UpdateCars([FromBody]Cars data, string Id)
        {
            data.id = Id;
            db.UpdateRecord<Cars>("Cars", Id, data);

            return "update data " + Id;
        }

        /*****************ADDRESSES****************/
        [Route("API/TEST/Addresses")]
        [HttpGet]
        public List<Addresses> GetAddresses()
        {
            return db.LoadRecords<Addresses>("Addresses");
        }

        [Route("API/TEST/Addresses/{Id}")]
        [HttpGet]
        public Addresses GetAddressesId(string Id)
        {
            return db.LoadRecordsbyId<Addresses>("Addresses", Id);
        }

        [Route("API/TEST/Addresses")]
        [HttpPost]
        public string PostAddresses([FromBody]Addresses data)
        {
            db.InsertData("Addresses", data);
            
            return "succes";
        }

        [Route("API/TEST/Addresses/{Id}")]
        [HttpDelete]
        public string DeleteAddresses(string Id)
        {
            db.DeleteRecord<Addresses>("Addresses", Id);
            return "delete data " + Id;
        }

        [Route("API/TEST/Addresses/Update/{Id}")]
        [HttpPut]
        public string UpdateAddresses([FromBody]Addresses data, string Id)
        {
            data.id = Id;
            db.UpdateRecord<Addresses>("Addresses", Id, data);

            return "update data " + Id;
        }




        /******************DRIVERS*****************/

        [Route("API/TEST/Drivers")]
        [HttpGet]
        public List<Drivers> GetDrivers()
        {
            // var a = db.LoadRecords<Addresses>("Addresses");
            return db.LoadRecords<Drivers>("Drivers");
        }
        [Route("API/TEST/Drivers/{Id}")]
        [HttpGet]
        public Drivers GetDriversById(string table, string Id)
        {
            return db.LoadRecordsbyId<Drivers>("Drivers", Id);
        }
        [Route("API/TEST/Drivers")]
        [HttpPost]
        public string PostDrivers([FromBody]Drivers data)
        {
            db.InsertData("Drivers", data);
            return "succes";
        }

        [Route("API/TEST/Drivers/{Id}")]
        [HttpDelete]
        public string DeleteDrivers(string Id)
        {
            db.DeleteRecord<Drivers>("Drivers", Id);
            return "delete record " + Id;
        }

        [Route("API/TEST/Drivers/Update/{Id}")]
        [HttpPut]
        public string Update([FromBody]Drivers data, string Id)
        {
            data.id = Id;
            db.UpdateRecord<Drivers>("Drivers", Id, data);

            return "update data " + Id;
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

        [HttpPost]
        public string PostPosition([FromBody]Position data)
        {
            db.InsertData("Position", data);
            return "succes";
        }

        [Route("API/TEST/Position/{Id}")]
        [HttpDelete]
        public string DeletePosition(string Id)
        {
            db.DeleteRecord<Position>("Position", Id);
            return "delete data " + Id;
        }

        [Route("API/TEST/Position/Update/{Id}")]
        [HttpPut]
        public string Update([FromBody]Position data, string Id)
        {
            data.id = Id;
            db.UpdateRecord<Position>("Position", Id, data);

            return "update data " + Id;
        }
        /*****************END***********************/


      




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
