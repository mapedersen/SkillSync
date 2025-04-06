using API.Features.Goal.Domain;
using API.Features.Log.Domain;
using API.Features.User.Domain;
using Microsoft.EntityFrameworkCore;

namespace API.Infra;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<UserEntity> Users => Set<UserEntity>();
    public DbSet<GoalEntity> Goals => Set<GoalEntity>();
    public DbSet<LogEntity> Logs => Set<LogEntity>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>()
            .HasMany(u => u.Goals)
            .WithOne(g => g.User)
            .HasForeignKey(g => g.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<GoalEntity>()
            .HasMany(g => g.Logs)
            .WithOne(l => l.Goal)
            .HasForeignKey(l => l.GoalId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
