using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<Config> Add(Config input)
        {
            return await _configRepository.AddAsync(input);
        }

        public async Task<Config> Update(Config input)
        {
            return await _configRepository.UpdateAsync(input, input.Id);
        }

        public async Task<int> Delete(Config input)
        {
            return await _configRepository.DeleteAsync(input);
        }

        public List<Config> GetAllConfigs()
        {
            return _configRepository.GetAll().ToList();
        }
    }
}
