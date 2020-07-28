using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11_1ClassExercise_EFCoreDbContextLINQSakilaDB
{
    class SakilaContext : DbContext
    {
        public DbSet<Actor> Actor { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\sqlexpress;Database=sakila;Trusted_Connection=True;");
        }

    }
}
