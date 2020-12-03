using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Claro.Api.ViewModels;
using Claro.Business.Interfaces;
using Claro.Business.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Claro.Api.Controllers
{
    [Route("claro/mobile")]
    [ApiController]
    public class MobileController : ControllerBase
    {
        private readonly IMobileRepository _mobileRepository;
        private readonly IMobileService _mobileService;
        private readonly IMapper _mapper;

        public MobileController(IMobileRepository mobileRepository,
            IMobileService mobileService,
            IMapper mapper)
        {
            _mobileRepository = mobileRepository;
            _mobileService = mobileService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<MobileViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<MobileViewModel>>(await _mobileRepository.ObterTodos());
        }

        [HttpGet("{code:guid}")]
        public async Task<ActionResult<MobileViewModel>> ObterPorId(Guid code)
        {
            var mobileViewModel = await ObterMobile(code);

            if (mobileViewModel == null) return NotFound();

            return mobileViewModel;
        }

        [HttpPost]
        public async Task<ActionResult<MobileViewModel>> Adicionar(MobileViewModel mobileViewModel)
        {
            await _mobileService.Adicionar(_mapper.Map<Mobile>(mobileViewModel));

            return mobileViewModel;
        }

        [HttpPut("{code:guid}")]
        public async Task<ActionResult<MobileViewModel>> Atualizar(Guid code, MobileViewModel mobileViewModel)
        {
            if (code != mobileViewModel.Code)
            {
                return NotFound();
            }

            var mobileAtualizada = await ObterMobile(code);

            mobileAtualizada.Model = mobileViewModel.Model;
            mobileAtualizada.Price = mobileViewModel.Price;
            mobileAtualizada.Brand = mobileViewModel.Brand;
            mobileAtualizada.Photo = mobileViewModel.Photo;
            mobileAtualizada.Date = mobileViewModel.Date;


            await _mobileService.Atualizar(_mapper.Map<Mobile>(mobileViewModel));

            return mobileViewModel;
        }

        [HttpDelete("{code:guid}")]
        public async Task<ActionResult<MobileViewModel>> Excluir(Guid code)
        {
            var mobile = await ObterMobile(code);

            if (mobile == null) return NotFound();

            await _mobileService.Remover(code);

            return mobile;
        }

        private async Task<MobileViewModel> ObterMobile(Guid code)
        {
            return _mapper.Map<MobileViewModel>(await _mobileRepository.ObterPorId(code));
        }


    }
}
