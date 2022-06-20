using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ShopWebsite.Services
{
    public class Service<T> : IService<T> where T : class
    {
        public Service()
        {

        }

        public List<SelectListItem> DropDownListItem(List<T> entity)
        {
            try{
                List<SelectListItem> dropDownListItem = new List<SelectListItem>();
                foreach(var item in entity){
                    dropDownListItem.Add(new SelectListItem{
                        Text = item.GetType().GetProperty("Name").GetValue(item).ToString(),
                        Value = item.GetType().GetProperty("Id").GetValue(item).ToString()
                    });
                }
                return dropDownListItem;
            }catch(Exception e){
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public List<SelectListItem> SeletedDropDownListItem(List<T> entity,T entity2)
        {
            try{
                List<SelectListItem> dropDownListItem = new List<SelectListItem>();

                foreach(var item in entity){
                    dropDownListItem.Add(new SelectListItem{
                        Text = item.GetType().GetProperty("Name").GetValue(item).ToString(),
                        Value = item.GetType().GetProperty("Id").GetValue(item).ToString(),
                        Selected = false
                    });
                }
                return dropDownListItem;
            }catch(Exception e){
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        
    }
}