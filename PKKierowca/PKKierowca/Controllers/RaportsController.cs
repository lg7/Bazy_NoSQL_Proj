using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Nancy.Json;
using PKKierowca.Models;
using System.Text;

namespace PKKierowca.Controllers
{
    /// <summary>
    /// Raportowanie
    /// </summary>
    [Authorize]
    public class RaportsController : ApiController
    {
        private HttpResponseMessage responseMessage(HttpStatusCode httpStatusCode, string response, string data)
        {
            HttpResponseMessage responseMessage = new HttpResponseMessage();
            if (httpStatusCode == HttpStatusCode.OK)
            {
                responseMessage.StatusCode = HttpStatusCode.OK;
                responseMessage.ReasonPhrase = response;
                responseMessage.Content = new StringContent(data, UnicodeEncoding.UTF8, "application/json");
                return responseMessage;
            }
            responseMessage.StatusCode = HttpStatusCode.BadRequest;
            return responseMessage;

        }
        private HttpResponseMessage responseMessage(HttpStatusCode httpStatusCode, string response)
        {
            HttpResponseMessage responseMessage = new HttpResponseMessage();
            if (httpStatusCode == HttpStatusCode.BadRequest)
            {
                responseMessage.StatusCode = HttpStatusCode.BadRequest;
                responseMessage.Content = new StringContent(response, UnicodeEncoding.UTF8, "application/json");
                //responseMessage.Content = new StringContent(data, UnicodeEncoding.UTF8, "application/json");
            }
            if (httpStatusCode == HttpStatusCode.OK)
            {
                responseMessage.StatusCode = HttpStatusCode.OK;
                responseMessage.Content = new StringContent(response, UnicodeEncoding.UTF8, "application/json");
                return responseMessage;
            }
            return responseMessage;
        }
        MongoCRUD db = new MongoCRUD("PKDriver");

        /// <summary>
        /// Raport ogolny na temat kierowcy
        /// </summary>
        /// <param name="Id">kierowcy</param>
        /// <returns>lista pozycji kierowcy</returns>
        [Route("Raports/Drivers/{Id}")]
        [HttpGet]
        public HttpResponseMessage GetInfoDrivers(string Id)
        {
            var a = db.LoadRecordsbyId<Drivers>("Drivers", Id);
            if (a != null)
            {
                var dTO = db.LoadRecordsbyPesel<Position>("Position", a.pesel);
                var json = new JavaScriptSerializer().Serialize(dTO);
                return responseMessage(HttpStatusCode.OK, "Succes", json);
            }
            return responseMessage(HttpStatusCode.BadRequest, "Driver doesn't exist");
        }
        /// <summary>
        /// Raport wykroczen kierowcy
        /// </summary>
        /// <param name="Id">kierowcy</param>
        /// <returns>lista pozycji kierowcy</returns>
        [Route("Raports/Drivers/TrafficOffenders/{Id}")]
        [HttpGet]
        public HttpResponseMessage GetInfoDriversTrafficOffenders(string Id)
        {
            var a = db.LoadRecordsbyId<Drivers>("Drivers", Id);
            if (a != null)
            {
                var dTO = db.DriversTrafficOffenders(a.pesel);
                var json = new JavaScriptSerializer().Serialize(dTO);
                return responseMessage(HttpStatusCode.OK, "Succes", json);
            }

            return responseMessage(HttpStatusCode.BadRequest, "Driver doesn't exist");

        }
        /// <summary>
        /// Raport wykroczen kierowcy w ostatnim miesiacu
        /// </summary>
        /// <param name="Id">kierowcy</param>
        /// <returns>lista pozycji kierowcy</returns>
        [Route("Raports/Drivers/TrafficOffendersMonth/{Id}")]
        [HttpGet]
        public HttpResponseMessage GetInfoDriversTrafficOffendersMonth(string Id)
        {

            var a = db.LoadRecordsbyId<Drivers>("Drivers", Id);
            if (a != null)
            {
                var dTO = db.DriversTrafficOffendersDate(a.pesel);
                var json = new JavaScriptSerializer().Serialize(dTO);
                return responseMessage(HttpStatusCode.OK, "Succes", json);
            }
            // return db.DriversTrafficOffendersDate(a.pesel);
            return responseMessage(HttpStatusCode.BadRequest, "Driver doesn't exist");

        }
        ///////////////////////////////////

        /// <summary>
        ///  Raport na temat pozycji samochodu  
        /// </summary>
        /// <param name="Id">id samochodu</param>
        /// <returns>lista pozycji samochodu</returns>
        [Route("Raports/Cars/{Id}")]
        [HttpGet]
        public HttpResponseMessage GetInfoCars(string Id)
        {

            var a = db.LoadRecordsbyId<Cars>("Cars", Id);
            if (a == null)
            {
                var dTO = db.LoadRecordsbyRn<Position>("Position", a.rn);
                var json = new JavaScriptSerializer().Serialize(dTO);
                return responseMessage(HttpStatusCode.OK, "Succes", json);
            }
            // return db.LoadRecordsbyRn<Position>("Position", a.rn);
            return responseMessage(HttpStatusCode.BadRequest, "Car doesn't exist");

        }
        /// <summary>
        ///  Raport na wykroczen z udziałem samochodu  
        /// </summary>
        /// <param name="Id">id samochodu</param>
        /// <returns>lista pozycji samochodu</returns>
        [Route("Raports/Cars/TrafficOffenders/{Id}")]
        [HttpGet]
        public HttpResponseMessage GetInfoCarsTrafficOffenders(string Id)
        {

            var a = db.LoadRecordsbyId<Cars>("Cars", Id);
            if (a != null)
            {
                var dTO = db.CarsTrafficOffenders(a.rn);
                var json = new JavaScriptSerializer().Serialize(dTO);
                return responseMessage(HttpStatusCode.OK, "Succes", json);
            }
            return responseMessage(HttpStatusCode.BadRequest, "Car doesn't exist");

        }
        /// <summary>
        ///  Raport na wykroczen z udziałem samochodu  z ostantiego miesiaca
        /// </summary>
        /// <param name="Id">id samochodu</param>
        /// <returns>lista pozycji samochodu</returns>
        [Route("Raports/Cars/TrafficOffendersMonth/{Id}")]
        [HttpGet]
        public HttpResponseMessage GetInfoCarsTrafficOffendersMonth(string Id)
        {

            var a = db.LoadRecordsbyId<Cars>("Cars", Id);
            if (a != null)
            {
                var dTO = db.CarsTrafficOffendersDate(a.rn);
                var json = new JavaScriptSerializer().Serialize(dTO);
                return responseMessage(HttpStatusCode.OK, "Succes", json);
            }
            return responseMessage(HttpStatusCode.BadRequest, "Car doesn't exist");

        }

    }
}
