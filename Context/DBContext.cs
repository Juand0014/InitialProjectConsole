using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Infrastructure;

namespace RCIInterface.Context;

public class DBContext : DbContext
{
    public DBContext(DbContextOptions<DbContext> options)
        : base(options)
    {
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }
}
