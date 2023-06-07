using ESunHomework.Models;
using System.Data.Entity;

namespace ESunHomework.DataAccess
{
    public class myDbContext : DbContext
    {
        public DbSet<ApiDataModel> Table1 { get; set; }
        public myDbContext() : base("LocalDBConnection")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApiDataModel>().ToTable("Table1");
        }
    }
    
}