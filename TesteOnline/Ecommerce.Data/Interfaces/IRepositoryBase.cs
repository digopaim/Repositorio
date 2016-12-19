using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Data.Contexto;

namespace Ecommerce.Data.Interfaces
{
   public interface  IRepositoreBase<T> where T : class
    {
        void Add(T obj);
        T GetbyId(int obj);
        void Update(T obj);
        void Delete(T obj);
        List<T> List();
        DataContext Context();


    }
}
