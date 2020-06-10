using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using PKKierowca.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PKKierowca.Controllers
{
    /// <summary>
    /// zarzadzanie baza
    /// </summary>
    [Authorize]
    public class BaseController : ApiController
    {
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
        public Cars GetCarsById(string Id)
        {
            return db.LoadRecordsbyId<Cars>("Cars", Id);
        }
        /// <summary>
        /// dodwanie nowego auta
        /// </summary>
        /// <param name="data">Obiekt Auta</param>
        /// <returns>informacje</returns>
        [Route("API/Cars")]
        [HttpPost]
        public string PostCars([FromBody] Cars data)
        {
            db.InsertData("Cars", data);
            return "succes";
        }
        /// <summary>
        /// usuniecie samochodu
        /// </summary>
        /// <param name="Id">id samochodu </param>
        /// <returns>id usunietgo rekodu</returns>
        [Route("API/Cars/{Id}")]
        [HttpDelete]
        public string DeleteCars(string Id)
        {
            db.DeleteRecord<Cars>("Cars", Id);
            return "delete record " + Id;
        }
        /// <summary>
        /// zaktualizowanie samochodu
        /// </summary>
        /// <param name="data">obiekt </param>
        /// <param name="Id">id obiektu</param>
        /// <returns>id zaktualizowanego obiektu</returns>
        [Route("API/Cars/Update/{Id}")]
        [HttpPut]
        public string UpdateCars([FromBody] Cars data, string Id)
        {
            data.id = Id;
            db.UpdateRecord<Cars>("Cars", Id, data);

            return "update data " + Id;
        }

        /*****************ADDRESSES****************/
        /// <summary>
        /// Lista adresow
        /// </summary>
        /// <returns>Lista</returns>
        [AllowAnonymous]
        [Route("API/Addresses")]
        [HttpGet]
        public List<Addresses> GetAddresses()
        {
            return db.LoadRecords<Addresses>("Addresses");
        }
        /// <summary>
        /// 1 adres
        /// </summary>
        /// <param name="Id">adres id</param>
        /// <returns>rekord</returns>
        [Route("API/Addresses/{Id}")]
        [HttpGet]
        public Addresses GetAddressesId(string Id)
        {
            return db.LoadRecordsbyId<Addresses>("Addresses", Id);
        }
        /// <summary>
        /// dodawanie nowego adresu
        /// </summary>
        /// <param name="data">Obiekt adres</param>
        /// <returns>informacje</returns>
        [Route("API/Addresses")]
        [HttpPost]
        public string PostAddresses([FromBody] Addresses data)
        {
            db.InsertData("Addresses", data);

            return "succes";
        }
        /// <summary>
        /// usuniecie adresu
        /// </summary>
        /// <param name="Id">id adresu</param>
        /// <returns>id usunietgo rekodu</returns>
        [Route("API/Addresses/{Id}")]
        [HttpDelete]
        public string DeleteAddresses(string Id)
        {
            db.DeleteRecord<Addresses>("Addresses", Id);
            return "delete data " + Id;
        }
        /// <summary>
        /// zaktualizowanie adresu
        /// </summary>
        /// <param name="data">obiekt </param>
        /// <param name="Id">id obiektu</param>
        /// <returns>id zaktualizowanego obiektu</returns>
        [Route("API/Addresses/Update/{Id}")]
        [HttpPut]
        public string UpdateAddresses([FromBody] Addresses data, string Id)
        {
            data.id = Id;
            db.UpdateRecord<Addresses>("Addresses", Id, data);

            return "update data " + Id;
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
            // var a = db.LoadRecords<Addresses>("Addresses");
            return db.LoadRecords<Drivers>("Drivers");
        }
        /// <summary>
        /// Kierowca
        /// </summary>
        /// <param name="Id">id kierowcy</param>
       /// <returns>rekord</returns>
        [Route("API/Drivers/{Id}")]
        [HttpGet]
        public Drivers GetDriversById(string table, string Id)
        {
            return db.LoadRecordsbyId<Drivers>("Drivers", Id);
        }
        /// <summary>
        /// dodaj kierowce
        /// </summary>
        /// <param name="data">Obiekt kierowca</param>
        /// <returns>informacje</returns>
        [Route("API/Drivers")]
        [HttpPost]
        public string PostDrivers([FromBody] Drivers data)
        {
            db.InsertData("Drivers", data);
            return "succes";
        }
        /// <summary>
        /// usuniecie kierowcy
        /// </summary>
        /// <param name="Id">id kierowcy</param>
        /// <returns>id usunietgo rekodu</returns>
        [Route("API/Drivers/{Id}")]
        [HttpDelete]
        public string DeleteDrivers(string Id)
        {
            db.DeleteRecord<Drivers>("Drivers", Id);
            return "delete record " + Id;
        }
        /// <summary>
        /// zaktualizowanie kierowcy
        /// </summary>
        /// <param name="data">obiekt </param>
        /// <param name="Id">id obiektu</param>
        /// <returns>id zaktualizowanego obiektu</returns>
        [Route("API/Drivers/Update/{Id}")]
        [HttpPut]
        public string Update([FromBody] Drivers data, string Id)
        {
            data.id = Id;
            db.UpdateRecord<Drivers>("Drivers", Id, data);

            return "update data " + Id;
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
            // var a = db.LoadRecords<Addresses>("Addresses");
            return db.LoadRecords<Position>("Position");
        }
        /// <summary>
        /// Pozycja
        /// </summary>
        /// <param name="Id">id pozycji</param>
       /// <returns>rekord</returns>
        [Route("API/Position/{Id}")]
        [HttpGet]
        public Position GetPositionById(string Id)
        {
            return db.LoadRecordsbyId<Position>("Position", Id);
        }
        /// <summary>
        /// dodwanie nowej pozycji
        /// </summary>
        /// <param name="data">Obiekt pozycja</param>
        /// <returns>informacje</returns>
        [AllowAnonymous]
        [HttpPost]
        public string PostPosition([FromBody] Position data)
        {
            db.InsertData("Position", data);
            return "succes";
        }
        /// <summary>
        /// usuniecie pozycji
        /// </summary>
        /// <param name="Id">id pozycji</param>
        /// <returns>id usunietgo rekodu</returns>
        [Route("API/Position/{Id}")]
        [HttpDelete]
        public string DeletePosition(string Id)
        {
            db.DeleteRecord<Position>("Position", Id);
            return "delete data " + Id;
        }
        /// <summary>
        /// zaktualizowanie pozycji
        /// </summary>
        /// <param name="data">obiekt </param>
        /// <param name="Id">id obiektu</param>
        /// <returns>id zaktualizowanego obiektu</returns>
        [Route("API/Position/Update/{Id}")]
        [HttpPut]
        public string Update([FromBody] Position data, string Id)
        {
            data.id = Id;
            db.UpdateRecord<Position>("Position", Id, data);

            return "update data " + Id;
        }
    


    }
}
