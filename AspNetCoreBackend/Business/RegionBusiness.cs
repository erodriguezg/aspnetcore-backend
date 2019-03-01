using AspNetCoreBackend.Entities;
using AspNetCoreBackend.Repositories;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace AspNetCoreBackend.Business
{
    public class RegionBusiness
    {
        private readonly RegionRepository _regionRepository;
        private readonly ILogger _logger;

        public RegionBusiness(RegionRepository regionRepository, ILogger<RegionBusiness> logger)
        {
            _regionRepository = regionRepository;
            _logger = logger;
        }

        public IList<Region> FindAllRegions()
        {
            _logger.LogDebug(" RegionBusiness.FindAllRegions!");
            return _regionRepository.FindAll();
        }

    }
}
