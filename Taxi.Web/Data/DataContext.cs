namespace Taxi.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using Taxi.Web.Data.Entities;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }
        public DbSet<TaxiEntity> Taxis { get; set; }
    }
}
