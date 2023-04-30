using JasonWeb1.Models;
using Microsoft.EntityFrameworkCore;


namespace JasonWeb1.Data
{
    //when we register applicationDB context, add these configurations below
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {//seed data 
            
            modelBuilder.Entity<Category>().HasData(
               //populate data rows
               //anything data changed or updated, need to add-migration in nuget package console line.
               //-> check if a file created or not in Migrations folder.
               //after changed, try to update-database in nuget package console
                new Category {CategoryId = 1, Name = "Action", DisplayOrder = 1 },
                new Category {CategoryId = 2, Name = "Scifi", DisplayOrder = 2 },
                new Category {CategoryId = 3, Name = "History", DisplayOrder = 3 }

                );
            
        }
    }

}
