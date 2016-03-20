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
            public List<Part> Parts { get; set; }
        }

        [HttpGet]
        public AirHandlingUnitCollection GetAll()
        {
            return new AirHandlingUnitRepository().GetAllCustomAirHandlingUnits();
        }

        [HttpGet]
        public AirHandlingUnit Get([FromUri]AirHandlingUnitRequest request)
        {
            return new AirHandlingUnitRepository().CreateNewAirHandlingUnit(request.Description, request.Parts);
        }
    }
}