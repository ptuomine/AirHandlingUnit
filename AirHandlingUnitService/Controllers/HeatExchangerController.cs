using AirHandlingUnits;
using AirHandlingUnits.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AirHandlingUnitService.Controllers
{
    public class HeatExchangerController : ApiController
    {
        //private readonly IRepository<Product> _repository;

        //public AirHandlingUnitController(IRepository<Product> repository)
        //{
        //    _repository = repository;
        //}

        public class HeatExchangerRequest
        {
            public string Description { get; set; }
            public int Power { get; set; }
            public HeatExchanger.HeatExchangerTypes HeatExchangerType { get; set; }
        }

        [HttpGet]
        public HeatExchangerCollection GetAll()
        {
            return new AirHandlingUnitRepository().GetAllCustomHeatExchangers();
        }

        [HttpGet]
        public HeatExchanger Get([FromUri]HeatExchangerRequest request)
        {
            return new AirHandlingUnitRepository().GetCustomHeatExchanger(request.Description, request.Power, request.HeatExchangerType);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}