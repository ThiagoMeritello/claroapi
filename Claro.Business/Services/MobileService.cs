using Claro.Business.Interfaces;
using Claro.Business.Models;
using System;
using System.Threading.Tasks;

namespace Claro.Business.Services
{
    public class MobileService : IMobileService
    {
        private readonly IMobileRepository _mobileRepository;

        public MobileService(IMobileRepository mobileRepository)
        {
            _mobileRepository = mobileRepository;
        }

        public async Task Adicionar(Mobile parcelaDespesa)
        {
            await _mobileRepository.Adicionar(parcelaDespesa);
        }

        public async Task Atualizar(Mobile parcelaDespesa)
        {
            await _mobileRepository.Atualizar(parcelaDespesa);
        }

        public async Task Remover(Guid code)
        {
            await _mobileRepository.Remover(code);
        }

        public void Dispose()
        {
            _mobileRepository?.Dispose();
        }
    }
}