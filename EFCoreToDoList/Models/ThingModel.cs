using System;

namespace EFCoreToDoList.Models
{
    public class ThingModel
    {
        public int Id{get;set;}
        public string Title{get;set;}
        public DateTime CreateTime{get;set;}
        public DateTime EndTime{get;set;}
    }
}