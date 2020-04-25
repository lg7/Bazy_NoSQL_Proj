using PKKierowca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PKKierowca.Controllers
{
    public class DriversController : ApiController
    {

        MongoCRUD db = new MongoCRUD("PKDriver");

        [Route("API/TEST/Drivers")]
        [HttpGet]
        public List<Drivers> GetDrivers()
        {
            // var a = db.LoadRecords<Addresses>("Addresses");
            return db.LoadRecords<Drivers>("Drivers");
        }
        //
        [Route("API/TEST/Drivers/{Id}")]
        [HttpGet]
        public Drivers GetDriversById(string table, string Id)
        {
            return db.LoadRecordsbyId<Drivers>("Drivers", Id);
        }
    }
}
