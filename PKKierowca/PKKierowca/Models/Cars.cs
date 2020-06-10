using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PKKierowca.Models
{/// <summary>
 /// 
 /// </summary>
    public class Cars
    {/// <summary>
     /// Id auta
     /// </summary>
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        /// <summary>
        /// Producent
        /// </summary>
        public string vendor { get; set; }
        /// <summary>
                                          /// Model
                                          /// </summary>

        public string model { get; set; }
        /// <summary>
        /// Seria
        /// </summary>
        public string line { get; set; }
        /// <summary>
        /// Pojemnosc
        /// </summary>
        public double capacity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int KMage { get; set; }
        /// <summary>
        /// Numer rejestracyjny
        /// </summary>
        public string rn { get; set; }
    }
}