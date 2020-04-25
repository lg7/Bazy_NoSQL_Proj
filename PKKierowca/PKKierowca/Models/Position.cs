using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PKKierowca.Models
{
    public class Position
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public int pos_x { get; set; }

        public int pos_y { get; set; }

        public string rn { get; set; }

        public string pesel { get; set; }

        public int speed { get; set; }

        public DateTime date { get; set; }
    }
}