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
        private readonly AirHandlingUnitRepository _repository = AirHandlingUnitRepository.GetInstance();

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
        public PartCollection GetAll()
        {
            return _repository.GetAllCustomParts<HeatExchanger>();
        }

        [HttpGet]
        public HeatExchanger Get([FromUri]HeatExchangerRequest request)
        {
            var partslist = new List<Object> {request.Description, request.Power, request.HeatExchangerType};
            return (HeatExchanger) _repository.GetCustomPart<HeatExchanger>(partslist);
        }

    }
}