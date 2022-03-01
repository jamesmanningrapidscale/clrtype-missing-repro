using System;
using Microsoft.EntityFrameworkCore;

namespace SomeEFUsingClassLib
{
    public class SomeContext : DbContext
    {
        public SomeContext(DbContextOptions<SomeContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("foo");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                Console.WriteLine($"Entity type {entityType} has clr type {entityType.ClrType}");
            }
        }

        public DbSet<Foo> Foo { get; set; }
    }

    public class Foo
    {
        public int Id { get; set; }
    }
}
