using Claro.Api.ViewModels;
using Claro.Business.Models;
using AutoMapper;

namespace Claro.Api.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Mobile, MobileViewModel>().ReverseMap();
        }
    }
}
