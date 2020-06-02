using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.DataAccess.Articles
{
    /// <summary>
    /// Article configuration.
    /// </summary>
    internal sealed class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("articles").HasKey(a => a.Id);
            builder.Property(a => a.Title).IsRequired().HasMaxLength(100).HasColumnName("article_title");
            builder.Property(a => a.Body).HasMaxLength(2000).HasColumnName("article_body");
            builder.Property(a => a.CreatedUserId).IsRequired().HasColumnName("created_user");
            builder.Property(a => a.CreatedDate).IsRequired().HasColumnName("created_date");
        }
    }
}
