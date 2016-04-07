using System.Linq;
using Microsoft.AspNet.Mvc;
using VehWebApp.Models.Dto;
using VehWebApp.Models.Vehicles;


namespace VehWebApp.Controllers
{
    [Route("/[controller]")]
    public class VehicleController : Controller
    {
        private IVehicleRepository _vehicleRepository;

        /// <summary>
        ///     DI again, we made our configuration in Startup.cs 
        ///     services.AddScoped<IVehicleRepository, VehicleRepository>();
        ///     now we will have it already instantiated here for our use
        /// </summary>        
        public VehicleController(IVehicleRepository vehicleRepository)
        {
            this._vehicleRepository = vehicleRepository;
        }

        // GET: vehicle/
        //[HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // GET: vehicle/list
        [HttpGet("list")]
        public IActionResult List()
        {
            var vehicles = from s in _vehicleRepository.GetVehicles()
                           select s;

            return new ObjectResult(vehicles);
        }

        // GET vehicle/5
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            return new ObjectResult(_vehicleRepository.GetVehicleByID(id));
        }

        // POST vehicle/
        [HttpPost]
        public IActionResult Post([FromBody]VehicleDto vehicleDto)
        {
            if (!ModelState.IsValid)
            {
                return new ObjectResult("Vehicle data is invalid");
            }
            else
            {
                var vehicle = new UsedVehicle()
                {
                    Code = vehicleDto.Code,
                    Name = vehicleDto.Name,
                    Description = vehicleDto.Description,
                    IssueDate = vehicleDto.IssueDate,
                    Kilometres = vehicleDto.Kilometres,
                    PurchaseDate = vehicleDto.PurchaseDate,
                    BasePrice = vehicleDto.Price
                };

                var addedVehicle = _vehicleRepository.InsertVehicle(vehicle);

                if (addedVehicle != null)
                {
                    return new ObjectResult(addedVehicle);
                }
                else
                {
                    return new ObjectResult("Failed to save data");
                }

            }
        }

        // PUT vehicle/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]UpdateVehicleInput vehicleInput)
        {
            if (!ModelState.IsValid)
            {
                return new ObjectResult("Vehicle data is invalid");
            }
            else
            {
                var vehicle = new UsedVehicle()
                {
                    Id = id,
                    Description = vehicleInput.Description,
                    Kilometres = vehicleInput.Kilometres,
                    PurchaseDate = vehicleInput.PurchaseDate,
                    BasePrice = vehicleInput.Price
                };

                _vehicleRepository.UpdateVehicle(vehicle);
                _vehicleRepository.Save();
            }

            //TODO: validate update, catch errors
            return new ObjectResult("Vehicle data update completed.");
        }

        // DELETE vehicle/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return new ObjectResult("Data is invalid");
            }
            else
            {
                _vehicleRepository.DeleteVehicle(id);
                _vehicleRepository.Save();
            }

            //TODO: validate delete, catch errors
            return new ObjectResult("Vehicle data delete completed.");
        }

    }
}