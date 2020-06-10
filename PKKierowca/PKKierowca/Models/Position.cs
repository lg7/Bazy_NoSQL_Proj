using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PKKierowca.Models
{
    /// <summary>
    /// Pozycje
    /// </summary>
    public class Position
    {
        /// <summary>
        /// id Pozycji
        /// </summary>
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        /// <summary>
        /// pos x
        /// </summary>
        public int pos_x { get; set; }
        /// <summary>
        /// pos y
        /// </summary>
        public int pos_y { get; set; }
        /// <summary>
        /// numer rejestreacyjny
        /// </summary>
        public string rn { get; set; }
        /// <summary>
        /// pesel
        /// </summary>
        public string pesel { get; set; }
        /// <summary>
        /// predkosc
        /// </summary>
        public int speed { get; set; }
        /// <summary>
        /// Data
        /// </summary>
        public DateTime date { get; set; }
    }
}