using AspNetCoreBackend.Business;
using AspNetCoreBackend.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace AspNetCoreBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly RegionBusiness _regionBusiness;
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(RegionBusiness regionBusiness, ILogger<ValuesController> logger)
        {
            _regionBusiness = regionBusiness;
            _logger = logger;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<Region>> Get()
        {
            _logger.LogDebug("Soy el Log del Index!");
            var regiones = _regionBusiness.FindAllRegions();
            return Ok(regiones);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            throw new NotSupportedException();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            throw new NotSupportedException();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotSupportedException();
        }
    }
}
