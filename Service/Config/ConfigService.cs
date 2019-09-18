using System.Collections.Generic;
using System.Linq;
using MicroService.Data.Abstract;
using MicroService.Model.Base;

namespace Service
{
    public class ConfigService : IConfigService
    {
        private readonly IConfigRepository _configRepository;

        public ConfigService(
            IConfigRepository configRepository
        )
        {
            _configRepository = configRepository;
        }

        public List<Config> GetAllConfigs()
        {
            return _configRepository.GetAll().ToList();
        }
    }
}
