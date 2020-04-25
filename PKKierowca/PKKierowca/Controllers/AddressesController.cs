
using PKKierowca.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PKKierowca.Controllers
{
    public partial class AddressesController : ApiController
    {/*
        MongoCRUD db1 = new MongoCRUD("PKDriver");
        // GET: api/Addresses
        [Route("API/TEST/Addresses")]
        [HttpGet]
        public List<Addresses> GetAddresses()
        {
            // var a = db.LoadRecords<Addresses>("Addresses");
            return db1.LoadRecords<Addresses>("Addresses");
        }

        [Route("API/TEST/Addresses/{Id}")]
        [HttpGet]
        public Cars GetAddressesId(string Id)
        {
            return db1.LoadRecordsbyId<Addresses>("Addresses", Id);
        }*/
        // POST: api/Addresses
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Addresses/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Addresses/5
        public void Delete(int id)
        {
        }
   
    }
}
