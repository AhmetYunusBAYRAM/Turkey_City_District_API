using Microsoft.AspNetCore.Mvc;

namespace CityAPI.Controllers
{
    [ApiController]
    [Route("/district")]
    public class DistrictController : ControllerBase
    {
        [HttpGet("{id}")]
        public IEnumerable<District> Get(int id)
        {
            Store.districtFill();
            
            return Enumerable.Range(0, 1).Select(index => new District
            {
                cityCode = id,
                districtName = Store.districtArray[id-1].districtName,
                cityName = Store.districtArray[id-1].cityName,
            })
            .ToArray();
        }
    }
}
