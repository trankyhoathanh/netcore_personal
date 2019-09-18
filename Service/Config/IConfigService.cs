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

        #endregion Method
    }
}
