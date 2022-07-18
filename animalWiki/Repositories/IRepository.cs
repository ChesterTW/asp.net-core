using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace ShopWebsite.Repository
{
    public interface IRepository<T>
    {
        /// <summary>
        /// 讀取特定一項資料
        /// </summary>
        /// <param name="id">要查找資料的id</param>
        /// <returns>該id的全部資料</returns>
        T Read(object id);
        /// <summary>
        /// 讀取全部的資料
        /// </summary>
        /// <returns>全部的資料</returns>
        List<T> Reads();
        /// <summary>
        /// Insert資料
        /// </summary>
        /// <param name="thing">給予數值供執行Insert語法</param>
        Boolean Create(T entity);
        Boolean Delete(T entity);
        Boolean BatchDelete(List<int> listId);
        Boolean Update(T entity);
        String CreateImage(IFormFile img);
        
    }
}