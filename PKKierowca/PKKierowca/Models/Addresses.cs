using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PKKierowca.Models
{
    public class Addresses
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public int pos_x { get; set; }
        public int pos_y { get; set; }
        public string address { get; set; }
    }
}