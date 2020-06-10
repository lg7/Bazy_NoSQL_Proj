using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PKKierowca.Models
{
    /// <summary>
    /// kierowcy
    /// </summary>
    public class Drivers
    {
        /// <summary>
        /// id kierowcy
        /// </summary>
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        /// <summary>
        /// imie
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// nazwisko
        /// </summary>
        public string lastname { get; set; }
        /// <summary>
        /// rok urodzenia
        /// </summary>
        public DateTime born { get; set; }
        /// <summary>
        /// Adres
        /// </summary>
        public string adress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string profession { get; set; }
        /// <summary>
        /// pesel
        /// </summary>
        public string pesel { get; set; }
    }
}