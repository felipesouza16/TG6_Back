using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public abstract class BaseRepository<M> where M : BaseModels
    {
        public void Create(M model)
        {
            using(var context = new BaseContext())
            {
                context.Set<M>().Add(model);
                context.SaveChanges();
            }
        }
        public List<M> Read()
        {
            using (var context = new BaseContext())
            {
                return context.Set<M>().ToList();
            }
        }
        public M Read (int id)
        {
            using (var context = new BaseContext())
            {
                return context.Set<M>().Find(id);
            }
        }
        public void Update(M model)
        {
            using(var context = new BaseContext())
            {
                context.Entry<M>(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using(var context = new BaseContext())
            {
                context.Entry<M>(Read(id)).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
