using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PKKierowca.Models
{
    public class Cars
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        public string vendor { get; set; }

        public string model { get; set; }

        public string line { get; set; }

        public double capacity { get; set; }

        public int KMage { get; set; }

        public string rn { get; set; }
    }
}