using APIMED.Businnes.DTO;
using APIMED.Businnes.ViewModel;
using APIMED.Domain.Entities;
using AutoMapper;

namespace APIMED.Application.Configuracao
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Contato, ContatoViewModel>().ReverseMap();
            CreateMap<ContatoDTO, ContatoViewModel>().ReverseMap();
        }
    }
}