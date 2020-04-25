using MongoDB.Bson.Serialization.Attributes;
using PKKierowca.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;



namespace PKKierowca.Controllers

{
    public class PositionController : ApiController
    {
        //CRUD2 db = new CRUD2("PKDriver");
        /*
        [Route("API/TEST/Position")]
        [HttpGet]
        public List<Position> GetPosition()
        {
            // var a = db.LoadRecords<Addresses>("Addresses");
            return db.LoadRecords<Position>("Position");
        }

        [Route("API/TEST/Position/{Id}")]
        [HttpGet]
        public Cars GetPositionById(string Id)
        {
            return db.LoadRecordsbyId<Position>("Position", Id);
        }*/
    }
}
