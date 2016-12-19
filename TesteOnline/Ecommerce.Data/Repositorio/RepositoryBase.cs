using Ecommerce.Data.Contexto;
using Ecommerce.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Ecommerce.Data.Repositorio
{
    public class RepositoryBase<T> : IRepositoreBase<T> where T : class
    {
        public static DataContext db = new DataContext();
        public void Add(T obj)
        {
            db.Set<T>().Add(obj);
            db.SaveChanges();
        }

        public void Delete(T obj)
        {
            db.Entry(obj).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public T GetbyId(int obj)
        {
            return db.Set<T>().Find(obj);
        }

        public List<T> List()
        {
            return db.Set<T>().ToList();
        }

        public void Update(T obj)
        {
            db.Entry(obj).State = EntityState.Modified;
                db.SaveChanges();
        }

        public DataContext Context()
        {
            return db = new DataContext();
        }


    }
}
