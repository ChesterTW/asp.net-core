using EFCoreToDoList.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreToDoList.Data
{
    public class TodolistDBContext : DbContext
    {
        DbSet<ThingModel> ThingsModel {get;set;}

        public TodolistDBContext(DbContextOptions<TodolistDBContext> options):base(options)
        {
            
        }


    }
}