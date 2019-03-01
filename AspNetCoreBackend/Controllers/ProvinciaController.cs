using AspNetCoreBackend.Business;
using AspNetCoreBackend.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace AspNetCoreBackend.Controllers
{
    [Route("provincias")]
    [ApiController]
    public class ProvinciaController : ControllerBase
    {
        private readonly ProvinciaBusiness _provinciaBusiness;
        private readonly ILogger _logger;
        public ProvinciaController(ProvinciaBusiness provinciaBusiness, ILogger<ProvinciaController> logger)
        {
            _logger = logger;
            _provinciaBusiness = provinciaBusiness;
        }

        [HttpGet("region/{idRegion}")]
        public IList<Provincia> traerPorIdRegion(int idRegion)
        {
            _logger.LogDebug("---> entre Provincias.TraerPorIdRegion(idRegion: {0}) ", idRegion);
            return _provinciaBusiness.FindByRegion(idRegion);
        }

    }
}
