using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PKKierowca.Models;

namespace PKKierowca.Controllers
{
    public class RaportsController : ApiController
    {

        MongoCRUD db = new MongoCRUD("PKDriver");




        [Route("Raports/Drivers/{Id}")]
        [HttpGet]
        public List<Position> GetInfoDrivers(string Id)
        {
            var a = db.LoadRecordsbyId<Drivers>("Drivers", Id);
            return db.LoadRecordsbyPesel<Position>("Position", a.pesel);

        }
        [Route("Raports/Drivers/TrafficOffenders/{Id}")]
        [HttpGet]
        public List<Position> GetInfoDriversTrafficOffenders(string Id)
        {
            var a = db.LoadRecordsbyId<Drivers>("Drivers", Id);

            return db.DriversTrafficOffenders(a.pesel);

        }

        [Route("Raports/Drivers/TrafficOffendersMonth/{Id}")]
        [HttpGet]
        public List<Position> GetInfoDriversTrafficOffendersMonth(string Id)
        {
            var a = db.LoadRecordsbyId<Drivers>("Drivers", Id);

            return db.DriversTrafficOffendersDate(a.pesel);

        }

        /// ///////////////////////////////////

        [Route("Raports/Cars/{Id}")]
        [HttpGet]
        public List<Position> GetInfoCars(string Id)
        {
            var a = db.LoadRecordsbyId<Cars>("Cars", Id);
            return db.LoadRecordsbyRn<Position>("Position", a.rn);

        }
        [Route("Raports/Cars/TrafficOffenders/{Id}")]
        [HttpGet]
        public List<Position> GetInfoCarsTrafficOffenders(string Id)
        {
            var a = db.LoadRecordsbyId<Cars>("Cars", Id);

            return db.CarsTrafficOffenders(a.rn);

        }

        [Route("Raports/Cars/TrafficOffendersMonth/{Id}")]
        [HttpGet]
        public List<Position> GetInfoCarsTrafficOffendersMonth(string Id)
        {
            var a = db.LoadRecordsbyId<Cars>("Cars", Id);

            return db.CarsTrafficOffendersDate(a.rn);

        }

    }
}
