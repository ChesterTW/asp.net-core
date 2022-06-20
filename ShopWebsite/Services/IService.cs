using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ShopWebsite.Services
{
    public interface IService<T>
    {
         public List<SelectListItem> DropDownListItem(List<T> entity);
         public List<SelectListItem> SeletedDropDownListItem(List<T> entity,T entity2);
    }
}