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
    public class FilterController : ApiController
    {

        private readonly AirHandlingUnitRepository repository = AirHandlingUnitRepository.GetInstance();
        public class FilterRequest
        {
            public string Description { get; set; }
            public int Length { get; set; }
        }

        [HttpGet]
        public PartCollection GetAll()
        {
            return repository.GetAllCustomParts<Filter>();
        }

        [HttpGet]
        public Filter Get([FromUri]FilterRequest request)
        {
            var partslist = new List<Object> {request.Description, request.Length};
            return (Filter) repository.GetCustomPart<Filter>(partslist);
        }
    }
}