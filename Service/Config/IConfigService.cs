using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MicroService.Model.Base;

namespace Service
{
    public interface IConfigService
    {
        #region Method

        List<Config> GetAllConfigs();
        Task<Config> Add(Config input);
        Task<Config> Update(Config input);
        Task<int> Delete(Config input);

        #endregion Method
    }
}
