using Microsoft.EntityFrameworkCore;
using TodosBackEnd.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodosBackEnd.Seeders;
using TodosBackEnd.Models;

namespace TodosBackEnd.Data
{
    public class TodosDbContext : DbContext
    {
        public TodosDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TodoConfiguration());
            modelBuilder.Seed();
        }

        public DbSet<Todo> Todos { get; set; }
    }
}
