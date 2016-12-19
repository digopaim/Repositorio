//using MOG.Domain.Entities;

using AutoMapper;
using Ecommerce.core.Entities;
using Ecommerce.Web.Models;

namespace Ecommerce.Web.Automapper
{
    public class DomainToVmMappingProfile : Profile
    {
        // Faz o mapeamento 

        public override string ProfileName
        {
            get { return "DomainToVMMappingProfile"; }
        }

        protected override void Configure()
        {

            CreateMap<LoginViewModel, Login>();
            CreateMap<MercadoriaViewModel, Mercadoria>();


        }
    }
}