using AutoMapper;
using Ecommerce.core.Entities;
using Ecommerce.Web.Models;

namespace Ecommerce.Web.Automapper
{
    public class VmToDomainMappingProfile : Profile
    {// Faz o mapeamento 

        public override string ProfileName
        {
            get { return "VMToDomainMappingProfile"; }
        }

        protected override void Configure()
        {
            CreateMap<Login, LoginViewModel>();
            CreateMap<Mercadoria, MercadoriaViewModel>();

        }
    }
}