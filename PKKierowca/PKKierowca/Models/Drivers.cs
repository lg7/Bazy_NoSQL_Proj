using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PKKierowca.Models
{
    public class Drivers
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public DateTime born { get; set; }
        public string adress { get; set; }
        public string profession { get; set; }
        public string pesel { get; set; }
    }
}