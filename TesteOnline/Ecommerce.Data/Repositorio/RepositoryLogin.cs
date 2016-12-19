using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.core.Entities;
using Ecommerce.Data.Interfaces;

namespace Ecommerce.Data.Repositorio
{
    public class RepositoryLogin: RepositoryBase<Login>,IRepositoryLogin
    {
        
        public dynamic Autenticacao(string usuario, string password)
        {
            var login = db.Login.FirstOrDefault(a => a.Usuario == usuario && a.Password == password);
            return login;
        }
    }
}
