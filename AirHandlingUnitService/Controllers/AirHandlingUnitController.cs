using AirHandlingUnits;
using AirHandlingUnits.Parts;
using System.Collections.Generic;
using System.Web.Http;

namespace AirHandlingUnitService.Controllers
{
    public class AirHandlingUnitController : ApiController
    {
        //private readonly IRepository<Product> _repository;

        //public AirHandlingUnitController(IRepository<Product> repository)
        //{
        //    _repository = repository;
        //}

        public class AirHandlingUnitRequest
        {
            public string Description { get; set; }
            public List<HeatExchanger> Parts { get; set; }
        }

        [HttpGet]
        public AirHandlingUnitCollection GetAll()
        {
            return new AirHandlingUnitRepository().GetAllCustomAirHandlingUnits();
        }

        [HttpGet]
        public AirHandlingUnit Get([FromUri]AirHandlingUnitRequest request)
        {
            List<Part> partslist = new List<Part>();
            foreach (var hepart in request.Parts)
            {
                partslist.Add(hepart);
            }
            return new AirHandlingUnitRepository().CreateNewAirHandlingUnit(request.Description, partslist);
        }
    }
}