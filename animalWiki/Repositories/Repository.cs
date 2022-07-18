using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using animalWiki.Models;

namespace ShopWebsite.Repository
{
    public class Repositories<T> : IRepository<T> where T : class
    {
        private readonly AnimalWikiContext ctx;
        private DbSet<T> _entity;
        public  Repositories(AnimalWikiContext dbContext){
            this.ctx = dbContext;
        }
        private DbSet<T> Entity => _entity ?? (_entity = ctx.Set<T>());
        public Boolean BatchDelete(List<int> listId)
        {
            throw new System.NotImplementedException();
        }

        public Boolean Create(T entity)
        {
            try{
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

        public T Read(object id)
        {
            return Entity.Find(id);
        }

        public List<T> Reads()
        {
            return Entity.ToList();
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

        public String CreateImage(IFormFile img)
        {
            try{
                String imgName="";
                String imgPath="";
                if(img != null && img.Length > 0){
                    imgName = img.FileName;
                    imgPath = Path.Combine(Directory.GetCurrentDirectory(),@"wwwroot/img", imgName);
                    using (var imgStream = new FileStream(imgPath,FileMode.Create)){
                        img.CopyTo(imgStream);
                    }
                }
                return imgName;
            }catch(Exception e){
                Console.WriteLine(e.ToString());
                return null;
            }

        }
    }
}