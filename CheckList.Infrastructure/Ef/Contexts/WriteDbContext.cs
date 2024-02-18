using CheckList.Domain.Entities;
using CheckList.Domain.ValueObjects;
using CheckList.Infrastructure.Ef.Config;
using Microsoft.EntityFrameworkCore;

namespace CheckList.Infrastructure.Ef.Contexts;

public class WriteDbContext : DbContext
{
    public DbSet<TravelerCheckList> TravelerCheckLists { get; set; }
    public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("TravelerCheckList");
        var configuration = new WriteConfiguration();
        modelBuilder.ApplyConfiguration<TravelerCheckList>(configuration);
        modelBuilder.ApplyConfiguration<TravelerItem>(configuration);
    }
}
