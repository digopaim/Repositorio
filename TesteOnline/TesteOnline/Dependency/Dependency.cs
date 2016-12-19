using Ecommerce.Data.Interfaces;
using Ecommerce.Data.Repositorio;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;

namespace Ecommerce.Web.Dependency
{
    public class Dependency
    {
        public SimpleInjectorDependencyResolver Container()
        {
            var container = new Container();

            // 2. Configure the container (register)
            // See below for more configuration examples
            container.Register(typeof(IRepositoreBase<>), typeof(RepositoryBase<>), Lifestyle.Scoped);
            container.Register(typeof(IRepositoryLogin), typeof(RepositoryLogin),Lifestyle.Transient);
            container.Register(typeof(IRepositoryMercadoria), typeof(RepositoryMercadoria),Lifestyle.Transient);
    

            // 3. Optionally verify the container's configuration.
            container.Verify();
            return new SimpleInjectorDependencyResolver(container);
        }
    }
}