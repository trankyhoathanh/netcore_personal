using System;
using MicroService.Model;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace MicroService.Controllers
{
    public class BasicController : Controller
    {
        private readonly IConfigService _configService;

        public BasicController(
            IConfigService configService
        )
        {
            _configService = configService;
        }

        #region Basic
        [HttpGet("basic/hello"), Produces("application/json")]
        public IActionResult Hello()
        {
            BaseReturnAPI result = new BaseReturnAPI()
            {
                Data = null,
                StatusCode = JsonApiStatusCodes.Default,
                Message = JsonApiStatusCodes.MessageDefault
            };

            try
            {
                result = new BaseReturnAPI()
                {
                    Data = _configService.GetAllConfigs(),
                    StatusCode = JsonApiStatusCodes.Success,
                    Message = JsonApiStatusCodes.MessageSucceed
                };
            }
            catch (Exception ex)
            {
                var k = ex.ToString();
                result.StatusCode = JsonApiStatusCodes.Failed;
                result.Message = k;
            }

            return Ok(result);
        }

        #endregion Basic
    }
}
