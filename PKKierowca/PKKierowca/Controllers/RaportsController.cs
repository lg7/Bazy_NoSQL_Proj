using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PKKierowca.Models;

namespace PKKierowca.Controllers
{
    /// <summary>
    /// Raportowanie
    /// </summary>
    [Authorize]
    public class RaportsController : ApiController
    {

        MongoCRUD db = new MongoCRUD("PKDriver");

        /// <summary>
        /// Raport ogolny na temat kierowcy
        /// </summary>
        /// <param name="Id">kierowcy</param>
        /// <returns>lista pozycji kierowcy</returns>
        [Route("Raports/Drivers/{Id}")]
        [HttpGet]
        public List<Position> GetInfoDrivers(string Id)
        {
            var a = db.LoadRecordsbyId<Drivers>("Drivers", Id);
            return db.LoadRecordsbyPesel<Position>("Position", a.pesel);

        }
        /// <summary>
        /// Raport wykroczen kierowcy
        /// </summary>
        /// <param name="Id">kierowcy</param>
        /// <returns>lista pozycji kierowcy</returns>
        [Route("Raports/Drivers/TrafficOffenders/{Id}")]
        [HttpGet]
        public List<Position> GetInfoDriversTrafficOffenders(string Id)
        {
            var a = db.LoadRecordsbyId<Drivers>("Drivers", Id);

            return db.DriversTrafficOffenders(a.pesel);

        }
        /// <summary>
        /// Raport wykroczen kierowcy w ostatnim miesiacu
        /// </summary>
        /// <param name="Id">kierowcy</param>
        /// <returns>lista pozycji kierowcy</returns>
        [Route("Raports/Drivers/TrafficOffendersMonth/{Id}")]
        [HttpGet]
        public List<Position> GetInfoDriversTrafficOffendersMonth(string Id)
        {
            var a = db.LoadRecordsbyId<Drivers>("Drivers", Id);

            return db.DriversTrafficOffendersDate(a.pesel);

        }
        ///////////////////////////////////

        /// <summary>
        ///  Raport na temat pozycji samochodu  
        /// </summary>
        /// <param name="Id">id samochodu</param>
        /// <returns>lista pozycji samochodu</returns>
        [Route("Raports/Cars/{Id}")]
        [HttpGet]
        public List<Position> GetInfoCars(string Id)
        {
            var a = db.LoadRecordsbyId<Cars>("Cars", Id);
            return db.LoadRecordsbyRn<Position>("Position", a.rn);

        }
        /// <summary>
        ///  Raport na wykroczen z udziałem samochodu  
        /// </summary>
        /// <param name="Id">id samochodu</param>
        /// <returns>lista pozycji samochodu</returns>
        [Route("Raports/Cars/TrafficOffenders/{Id}")]
        [HttpGet]
        public List<Position> GetInfoCarsTrafficOffenders(string Id)
        {
            var a = db.LoadRecordsbyId<Cars>("Cars", Id);

            return db.CarsTrafficOffenders(a.rn);

        }
        /// <summary>
        ///  Raport na wykroczen z udziałem samochodu  z ostantiego miesiaca
        /// </summary>
        /// <param name="Id">id samochodu</param>
        /// <returns>lista pozycji samochodu</returns>
        [Route("Raports/Cars/TrafficOffendersMonth/{Id}")]
        [HttpGet]
        public List<Position> GetInfoCarsTrafficOffendersMonth(string Id)
        {
            var a = db.LoadRecordsbyId<Cars>("Cars", Id);

            return db.CarsTrafficOffendersDate(a.rn);

        }

    }
}
