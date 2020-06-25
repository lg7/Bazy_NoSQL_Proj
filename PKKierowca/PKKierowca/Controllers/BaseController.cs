
using PKKierowca.Models;

using System.Collections.Generic;

using System.Net;
using System.Net.Http;
using System.Web.Http;
using Nancy.Json;
using Nancy.Json.Simple;
using System.Text;
using System;

namespace PKKierowca.Controllers
{
    /// <summary>
    /// zarzadzanie baza
    /// </summary>
    [Authorize]
    public class BaseController : ApiController
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
        /******************CARS********************/
        /// <summary>
        /// Lista Auto
        /// </summary>
        /// <returns>Lista</returns>
        [Route("API/Cars")]
        [HttpGet]
        public List<Cars> GetCars()
        {
            return db.LoadRecords<Cars>("Cars");
        }
        /// <summary>
        /// /
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>rekord</returns>
        [Route("API/Cars/{Id}")]
        [HttpGet]
        public HttpResponseMessage GetCarsById(string Id)
        {

            if (db.LoadRecordsbyId<Cars>("Cars", Id) != null)
            {
                Cars auto = db.LoadRecordsbyId<Cars>("Cars", Id);

                var json = new JavaScriptSerializer().Serialize(auto);
                return responseMessage(HttpStatusCode.OK, "Succes", json);
            }
            return responseMessage(HttpStatusCode.BadRequest, "Car doesn't exist");
        }


        /// <summary>
        /// dodwanie nowego auta
        /// </summary>
        /// <param name="data">Obiekt Auta</param>
        /// <returns>informacje</returns>
        [Route("API/Cars")]
        [HttpPost]
        public HttpResponseMessage PostCars([FromBody] Cars data)
        {

            if (db.LoadRecordsbyCar<Cars>(data.rn) == null)
            {
                db.InsertData("Cars", data);
                //responseMessage.StatusCode = HttpStatusCode.OK;
                //responseMessage.ReasonPhrase = "Succes";
                //responseMessage.Content = new StringContent("Add record");
                //return responseMessage;
                return responseMessage(HttpStatusCode.OK,
                                       "Succes");
            }
            //responseMessage.StatusCode = HttpStatusCode.BadRequest;
            //responseMessage.Content = new StringContent("Car doesn't exist");
            //return responseMessage;

            return responseMessage(HttpStatusCode.BadRequest, "Car doesn't exist");


        }
        /// <summary>
        /// usuniecie samochodu
        /// </summary>
        /// <param name="Id">id samochodu </param>
        /// <returns>id usunietgo rekodu</returns>
        [Route("API/Cars/{Id}")]
        [HttpDelete]
        public HttpResponseMessage DeleteCars(string Id)
        {
            if (db.LoadRecordsbyId<Cars>("Cars", Id) != null)
            {
                db.DeleteRecord<Cars>("Cars", Id);
                return responseMessage(HttpStatusCode.OK, "Succes", "Delete record");
            }

            return responseMessage(HttpStatusCode.BadRequest, "Car doesn't exist");
        }
        /// <summary>
        /// zaktualizowanie samochodu
        /// </summary>
        /// <param name="data">obiekt </param>
        /// <param name="Id">id obiektu</param>
        /// <returns>id zaktualizowanego obiektu</returns>
        [Route("API/Cars/Update/{Id}")]
        [HttpPut]
        public HttpResponseMessage UpdateCars([FromBody] Cars data, string Id)
        {
            if (db.LoadRecordsbyId<Cars>("Cars", Id) != null)
            {
                data.id = Id;
                db.UpdateRecord<Cars>("Cars", Id, data);
                return responseMessage(HttpStatusCode.OK,
                                  "Succes", "Update record");
            }
            return responseMessage(HttpStatusCode.BadRequest, "Car doesn't exist");
        }




        /******************DRIVERS*****************/
        /// <summary>
        /// Lista kierowcow
        /// </summary>
        /// <returns>Lista</returns>
        [Route("API/Drivers")]
        [HttpGet]
        public List<Drivers> GetDrivers()
        {
            return db.LoadRecords<Drivers>("Drivers");
        }
        /// <summary>
        /// Kierowca
        /// </summary>
        /// <param name="Id">id kierowcy</param>
        /// <returns>rekord</returns>
        [Route("API/Drivers/{Id}")]
        [HttpGet]
        public HttpResponseMessage GetDriversById(string Id)
        {
            if (db.LoadRecordsbyId<Drivers>("Drivers", Id) != null)
            {
                Drivers drivers = db.LoadRecordsbyId<Drivers>("Drivers", Id);

                var json = new JavaScriptSerializer().Serialize(drivers);

                return responseMessage(HttpStatusCode.OK, "Succes", json);


            }
            return responseMessage(HttpStatusCode.BadRequest, "Driver doesn't exist");
        }
        /// <summary>
        /// dodaj kierowce
        /// </summary>
        /// <param name="data">Obiekt kierowca</param>
        /// <returns>informacje</returns>
        [Route("API/Drivers")]
        [HttpPost]
        public HttpResponseMessage PostDrivers([FromBody] Drivers data)
        {

            if (db.LoadRecordsbyCar<Drivers>(data.pesel) == null)
            {
                db.InsertData("Drivers", data);

                return responseMessage(HttpStatusCode.OK, "Succes", "Add record");

            }

            return responseMessage(HttpStatusCode.BadRequest, "Driver doesn't exist");
        }
        /// <summary>
        /// usuniecie kierowcy
        /// </summary>
        /// <param name="Id">id kierowcy</param>
        /// <returns>id usunietgo rekodu</returns>
        [Route("API/Drivers/{Id}")]
        [HttpDelete]
        public HttpResponseMessage DeleteDrivers(string Id)
        {

            if (db.LoadRecordsbyId<Drivers>("Drivers", Id) != null)
            {
                db.DeleteRecord<Drivers>("Drivers", Id);
                return responseMessage(HttpStatusCode.OK, "Succes", "Delete record");
            }

            return responseMessage(HttpStatusCode.BadRequest, "Driver doesn't exist");
        }
        /// <summary>
        /// zaktualizowanie kierowcy
        /// </summary>
        /// <param name="data">obiekt </param>
        /// <param name="Id">id obiektu</param>
        /// <returns>id zaktualizowanego obiektu</returns>
        [Route("API/Drivers/Update/{Id}")]
        [HttpPut]
        public HttpResponseMessage Update([FromBody] Drivers data, string Id)
        {
            if (db.LoadRecordsbyId<Drivers>("Drivers", Id) != null)
            {
                data.id = Id;
                db.UpdateRecord<Drivers>("Drivers", Id, data);

                return responseMessage(HttpStatusCode.OK, "update data " + Id);
            }
            return responseMessage(HttpStatusCode.BadRequest, "Driver doesn't exist");
        }

        /***************POSITON********************/
        /// <summary>
        /// ListaPozycji 
        /// </summary>
        /// <returns>Lista</returns>
        [Route("API/Position")]
        [HttpGet]
        public List<Position> GetPosition()
        {
            return db.LoadRecords<Position>("Position");
        }
        /// <summary>
        /// Pozycja
        /// </summary>
        /// <param name="Id">id pozycji</param>
        /// <returns>rekord</returns>
        [Route("API/Position/{Id}")]
        [HttpGet]
        public HttpResponseMessage GetPositionById(string Id)
        {
            if (db.LoadRecordsbyId<Drivers>("Drivers", Id) != null)
            {
                Position position = db.LoadRecordsbyId<Position>("Position", Id);
                var json = new JavaScriptSerializer().Serialize(position);
                return responseMessage(HttpStatusCode.OK, "Succes", json);
            }
            return responseMessage(HttpStatusCode.BadRequest, "Position doesn't exist");
        }
        /// <summary>
        /// dodwanie nowej pozycji
        /// </summary>
        /// <param name="data">Obiekt pozycja</param>
        /// <returns>informacje</returns>
        [AllowAnonymous]
        [HttpPost]
        public HttpResponseMessage PostPosition([FromBody] Position data)
        {

            db.InsertData("Position", data);
            return responseMessage(HttpStatusCode.OK, "Succes", "Added record");
        }
        /// <summary>
        /// usuniecie pozycji
        /// </summary>
        /// <param name="Id">id pozycji</param>
        /// <returns>id usunietgo rekodu</returns>
        [Route("API/Position/{Id}")]
        [HttpDelete]
        public HttpResponseMessage DeletePosition(string Id)
        {
            if (db.LoadRecordsbyId<Drivers>("Drivers", Id) != null)
            {
                db.DeleteRecord<Position>("Position", Id);
                return responseMessage(HttpStatusCode.OK, "Succes", "delete data " + Id);
            }
            return responseMessage(HttpStatusCode.BadRequest, "Position doesn't exist");
        }
        /// <summary>
        /// zaktualizowanie pozycji
        /// </summary>
        /// <param name="data">obiekt </param>
        /// <param name="Id">id obiektu</param>
        /// <returns>id zaktualizowanego obiektu</returns>
        [Route("API/Position/Update/{Id}")]
        [HttpPut]
        public HttpResponseMessage Update([FromBody] Position data, string Id)
        {
            if (db.LoadRecordsbyId<Drivers>("Drivers", Id) != null)
            {
                data.id = Id;
                db.UpdateRecord<Position>("Position", Id, data);
                return responseMessage(HttpStatusCode.OK, "Succes", "Update data " + Id);
            }
            return responseMessage(HttpStatusCode.BadRequest, "Position doesn't exist");
        }



    }
}
