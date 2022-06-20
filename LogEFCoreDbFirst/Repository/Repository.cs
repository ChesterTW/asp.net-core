using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using LogEFCoreDbFirst.Data;
using Microsoft.EntityFrameworkCore;

namespace LogEFCoreDbFirst.Repository
{
    public class Repositories<T> : IRepository<T> where T : BaseModel
    {
        private readonly InternContext ctx;
        private DbSet<T> _entity;
        public Repositories(InternContext dbContext)
        {
            this.ctx = dbContext;
        }

        private DbSet<T> Entity => _entity ?? (_entity = ctx.Set<T>());

        public T Read(object id)
        {
            return Entity.Find(id);
        }

        public List<T> Reads()
        {
            return Entity.ToList();
        }

        public Boolean Create(T entity)
        {
            try{
                Type type = entity.GetType();
                foreach (var prop in type.GetProperties())
                {   
                    if(prop.Name=="CreateTime"){
                        prop.SetValue(entity,DateTime.Now);
                    }
                }
                Entity.Add(entity);
                ctx.SaveChanges();
                return true;
            }catch(Exception e){
                Console.WriteLine(e.ToString());
            }
            return false;
        }

        public Boolean Delete(T entity)
        {
            try{
                Entity.Remove(entity);
                ctx.SaveChanges();
                return true;
            }catch(Exception e){
                Console.WriteLine(e.ToString());
            }
            return false;
        }

        public Boolean BatchDelete(List<int> listId)
        {
            try{
                Entity.RemoveRange(Entity.Where(id => listId.Contains(id.Id)));
                ctx.SaveChanges();
                return true;
            }catch(Exception e){
                Console.WriteLine(e.ToString());
            }
            return false;
        }

        public Boolean Update(T entity)
        {
            try{
                Entity.Update(entity);
                ctx.SaveChanges();
                return true;
            }catch(Exception e){
                Console.WriteLine(e.ToString());
            }
            return false;
        }
    }
}