using AutoMapper;

namespace Ecommerce.Web.Automapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
                  {
                      x.AddProfile<DomainToVmMappingProfile>();
                      x.AddProfile<VmToDomainMappingProfile>();
                  });
        }
    }
}