using Claro.Business.Interfaces;
using Claro.Business.Models;
using Claro.Data.Context;

namespace Claro.Data.Repository
{
    public class MobileRepository : Repository<Mobile>, IMobileRepository
    {
        public MobileRepository(MeuDbContext context) : base(context) { }
    }
}
