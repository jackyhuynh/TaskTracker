using Microsoft.EntityFrameworkCore;

namespace BackEnd2.Models
{
    /* The TodoContext extend the Database Context
     */
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
