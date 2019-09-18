using System.ComponentModel.DataAnnotations;

namespace MicroService.Model.Base
{
    public class Config
    {
        [Key]
        public int Id { get; set; }
        public string Key { get; set; }
    }
}
