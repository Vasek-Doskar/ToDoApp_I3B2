using Microsoft.EntityFrameworkCore;
using ToDoApp_I3B2.Model;

namespace ToDoApp_I3B2.Database
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<ToDo> ToDos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = ToDoDb.db");
        }
    }
}
