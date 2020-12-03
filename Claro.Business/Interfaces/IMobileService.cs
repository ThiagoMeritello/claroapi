using Claro.Business.Models;
using System;
using System.Threading.Tasks;

namespace Claro.Business.Interfaces
{
    public interface IMobileService : IDisposable
    {
        Task Adicionar(Mobile mobile);
        Task Atualizar(Mobile mobile);
        Task Remover(Guid code);
    }
}
