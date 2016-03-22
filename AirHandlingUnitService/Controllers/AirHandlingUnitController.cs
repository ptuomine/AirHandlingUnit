using AirHandlingUnits;
using AirHandlingUnits.Parts;
using System.Collections.Generic;
using System.Web.Http;

namespace AirHandlingUnitService.Controllers
{
    public class AirHandlingUnitController : ApiController
    {

        private readonly AirHandlingUnitRepository repository = AirHandlingUnitRepository.GetInstance();

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
            return repository.GetAllCustomAirHandlingUnits();
        }

        [HttpGet]
        public AirHandlingUnits.AirHandlingUnit Get([FromUri]AirHandlingUnitRequest request)
        {
            return repository.CreateNewAirHandlingUnit(request.Description, request.Parts);
        }
    }
}