using AspNetCoreBackend.Entities;
using AspNetCoreBackend.Repositories;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace AspNetCoreBackend.Business
{
    public class ProvinciaBusiness
    {

        private readonly ILogger<ProvinciaBusiness> _logger;
        private readonly ProvinciaRepository _provinciaRepository;

        public ProvinciaBusiness(ProvinciaRepository provinciaRepository, ILogger<ProvinciaBusiness> logger)
        {
            _provinciaRepository = provinciaRepository;
            _logger = logger;
            _logger.LogDebug("======> CREANDO INSTANCIA DE ProvinciaBusiness!");
        }


        public IList<Provincia> FindByRegion(long idRegion)
        {
            _logger.LogDebug("========> FindByRegion. IdRegion: {0}", idRegion);
            return _provinciaRepository.FindByRegion(idRegion);
        }

    }
}
