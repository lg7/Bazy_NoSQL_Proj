using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json.Linq;

namespace PKKierowca.Models
{
    /// <summary>
    /// Adressy kierowcow
    /// </summary>
    public class Addresses
    {
        /// <summary>
        /// ID Adress
        /// </summary>
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        /// <summary>
        /// Pos X
        /// </summary>
        public int pos_x { get; set; }
        /// <summary>
        /// Pos Y
        /// </summary>
        public int pos_y { get; set; }
        /// <summary>
        /// adres domowy
        /// </summary>
        public string address { get; set; }
        /*
        public Addresses(string json)
        {
            JObject jObject = JObject.Parse(json);
            JToken jAddresses = jObject["Addresses"];
            pos_x = (int)jAddresses["pos_x"];
            pos_y = (int)jAddresses["pos_y"];
            address = (string)jAddresses["email"];
        }*/
    }
}