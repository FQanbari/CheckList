using CheckList.Infrastructure.Ef.Config;
using CheckList.Infrastructure.Ef.Models;
using Microsoft.EntityFrameworkCore;

namespace CheckList.Infrastructure.Ef.Contexts;

public class ReadDbContext : DbContext
{
    public DbSet<TravelerCheckListReadModel> TravelerCheckList { get; set; }
    public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("TravelerCheckList");
        var configuration = new ReadConfiguration();
        modelBuilder.ApplyConfiguration<TravelerCheckListReadModel>(configuration);
        modelBuilder.ApplyConfiguration<TravelerItemReadModel>(configuration);
    }
}
