using MongoDB.Bson.Serialization.Attributes;
using PKKierowca.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PKKierowca.Controllers;

namespace PKKierowca.Controllers
{
    public class CarsController : ApiController
    {
        /*
        MongoCRUD db = new MongoCRUD("PKDriver");

        [Route("API/TEST/Cars")]
        [HttpGet]
        public List<Cars> GetCars()
        {
            // var a = db.LoadRecords<Addresses>("Addresses");
            return db.LoadRecords<Cars>("Cars");
        }
/*
        [Route("API/TEST/Cars/{Id}")]
        [HttpGet]
        public Cars GetCarsById(string Id)
        {
            return db.LoadRecordsbyId<Cars>("Cars", Id);
        }*/
    }
}
