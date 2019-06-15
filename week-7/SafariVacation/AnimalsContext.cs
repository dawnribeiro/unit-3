using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SafariVacation
{
  public partial class AnimalsContext : DbContext
  {
    public AnimalsContext()
    {
    }

    public AnimalsContext(DbContextOptions<AnimalsContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseNpgsql("server=localhost;database=Animals");
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");
    }

    public DbSet<AnimalsSeen> AnimalsSeen { get; set; }
  };
};