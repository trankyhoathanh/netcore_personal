using System;
using System.Linq;
using MicroService.Data.Abstract;
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
        public IActionResult ValidateEmail()
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
                var k = ex;
                result.StatusCode = JsonApiStatusCodes.Failed;
                result.Message = k.ToString();
            }

            return Ok(result);
        }

        [HttpGet("basic/hello2"), Produces("application/json")]
        public IActionResult Hello2()
        {
            BaseReturnAPI result = new BaseReturnAPI()
            {
                Data = null,
                StatusCode = JsonApiStatusCodes.Default,
                Message = "Hello 2"
            };

            return Ok(result);
        }

        [HttpGet("basic/hello3"), Produces("application/json")]
        public IActionResult Hello3()
        {
            BaseReturnAPI result = new BaseReturnAPI()
            {
                Data = null,
                StatusCode = JsonApiStatusCodes.Default,
                Message = "Hello 3 - test Jenkins"
            };

            return Ok(result);
        }

        #endregion Basic
    }
}
