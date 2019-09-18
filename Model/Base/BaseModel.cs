using System;
namespace MicroService.Model
{
    public class BaseReturnAPI
    {
        public object Data { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}
