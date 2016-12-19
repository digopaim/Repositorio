using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.core.Entities;

namespace Ecommerce.Data.Interfaces
{
    public interface IRepositoryLogin:IRepositoreBase<Login>
    {
        dynamic Autenticacao(string usuario, string password);
    }
}
