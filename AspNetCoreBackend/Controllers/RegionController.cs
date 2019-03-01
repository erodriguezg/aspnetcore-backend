using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreBackend.Business;
using AspNetCoreBackend.Entities;
using AspNetCoreBackend.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetCoreBackend.Controllers
{
    [Route("regiones")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly RegionBusiness _regionBusiness;
        private readonly ILogger<RegionController> _logger;

        public RegionController(RegionBusiness regionBusiness, ILogger<RegionController> logger)
        {
            _regionBusiness = regionBusiness;
            _logger = logger;
        }

        [HttpGet("todas")]
        public IList<Region> GetRegiones()
        {
            _logger.LogDebug("----> Entro a GetRegiones");
            return _regionBusiness.FindAllRegions();
        }

    }
}