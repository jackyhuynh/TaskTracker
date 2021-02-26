using Microsoft.EntityFrameworkCore;

namespace BackEnd2.Models
{
    /* The TodoContext extend the Database Context
     * from Microsoft.EntityFrameworkCore
     */
    public class TodoContext : DbContext
    {
        /* The DbContextOptions
         * from Microsoft.EntityFrameworkCore
         * Please click on DbContextOptions link in Visual Studio for more information
         * Type parameters:
         *      TContext:
         *      The type of the context these options apply to.
         */
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }
        //     A Microsoft.EntityFrameworkCore.DbSet`1 can be used to query and save instances
        //     of TEntity. LINQ queries against a Microsoft.EntityFrameworkCore.DbSet`1 will
        //     be translated into queries against the database.
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
