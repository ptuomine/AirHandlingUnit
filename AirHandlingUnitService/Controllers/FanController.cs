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
    public class FanController : ApiController
    {

        private readonly AirHandlingUnitRepository repository = AirHandlingUnitRepository.GetInstance();
        public class FanRequest
        {
            public string Description { get; set; }
            public Fan.FanTypes FanType { get; set; }
        }

        [HttpGet]
        public PartCollection GetAll()
        {
            return repository.GetAllCustomParts<Fan>();
        }

        [HttpGet]
        public Fan Get([FromUri]FanRequest request)
        {
            var partslist = new List<Object> {request.Description, request.FanType};
            return (Fan) repository.GetCustomPart<Fan>(partslist);
        }
    }
}