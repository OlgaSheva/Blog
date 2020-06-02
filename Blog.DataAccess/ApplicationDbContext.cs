using Microsoft.EntityFrameworkCore;

namespace Blog.DataAccess
{
    internal sealed class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base()
        { }

        public DbSet<Article> Articles { get; set; }

        public DbSet<Comment> Comments { get; set; }
    }
}
