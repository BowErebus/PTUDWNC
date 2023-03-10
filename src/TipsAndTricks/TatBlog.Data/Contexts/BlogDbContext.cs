using Microsoft.EntityFrameworkCore;
using TatBlog.Core.Entities;
using TatBlog.Data.Mappings;

namespace TatBlog.Data.Contexts;

public class BlogDbContext : DbContext
{
    public DbSet<Author> Authors { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Post> Posts { get; set; }

    public DbSet<Tag> Tags { get; set; }

    // --- Lab01 ---
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Bạn phải thay đổi chuỗi kết nối cho phù hợp
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-J6GLMIC\SQLEXPRESS;Database=TatBlog;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
    }

    // --- Lab02 ---
    public BlogDbContext(DbContextOptions<BlogDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(CategoryMap).Assembly);
    }

    public BlogDbContext()
    {
    }
}