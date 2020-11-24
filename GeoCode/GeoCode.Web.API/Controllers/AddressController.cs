using GeoCode.Interfaces;
using GeoCode.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoCode.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _coordinateService;
        public AddressController(IAddressService coordinateService)
        {
            _coordinateService = coordinateService;
        }

        [HttpGet("coordinates")]
        public Address Get([FromQuery]string address)
        {
            return _coordinateService.GetAddressCoordinates(address);
        }

        [HttpGet("popular-search")]
        public IEnumerable<Address> Get([FromQuery]int numberOfPopularSearches)
        {
            return _coordinateService.GetPopularSearch(numberOfPopularSearches);
        }

    }
}
