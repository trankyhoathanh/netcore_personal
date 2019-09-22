using System;
using MicroService.Model;
using MicroService.Model.Base;
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
        [HttpGet("config"), Produces("application/json")]
        public IActionResult ConfigGet()
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

        [HttpPost("config"), Produces("application/json")]
        public IActionResult ConfigPost(Config input)
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
                    Data = _configService.Add(input),
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

        [HttpPut("config"), Produces("application/json")]
        public IActionResult ConfigPut(Config input)
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
                    Data = _configService.Update(input),
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

        [HttpDelete("config"), Produces("application/json")]
        public IActionResult ConfigDelete(Config input)
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
                    Data = _configService.Delete(input),
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
