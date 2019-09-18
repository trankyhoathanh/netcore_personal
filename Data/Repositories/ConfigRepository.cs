using MicroService.Data.Abstract;
using MicroService.Model.Base;

namespace MicroService.Data.Repositories
{
    public class ConfigRepository : EntityBaseRepository<Config>, IConfigRepository
    {
        private LocalContext _context;
        public ConfigRepository(LocalContext context) : base(context)
        { _context = context; }
    }
}
