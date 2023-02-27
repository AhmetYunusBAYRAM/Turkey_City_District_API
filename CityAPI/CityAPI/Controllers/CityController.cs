using Microsoft.AspNetCore.Mvc;

namespace CityAPI.Controllers
{
    [ApiController]
    [Route("/city")]
    public class CityController : ControllerBase
    {

        private readonly ILogger<CityController> _logger;

        public CityController(ILogger<CityController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCity")]
        public IEnumerable<City> Get()
        {
            return Enumerable.Range(1, 81).Select(index => new City
            {
               cityCode = index,
               cityName = Store.cityArray[index - 1],
            })
            .ToArray();
        }

      
       
    }
}