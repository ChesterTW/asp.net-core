using System;

namespace LogEFCoreDbFirst.Data
{
    public abstract class BaseModel
    {
        public abstract int Id{get;set;}
        public abstract string Title{get;set;}
        public abstract DateTime CreateTime{get;set;}
        public abstract DateTime EndTime{get;set;}
    }
}