using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.DataAccess.Comments
{
    /// <summary>
    /// Article configuration.
    /// </summary>
    internal sealed class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("comments").HasKey(a => a.Id);
            builder.Property(a => a.Body).HasMaxLength(2000).HasColumnName("comment_body");
            builder.Property(a => a.ArticleId).IsRequired().HasColumnName("article_id");
            builder.Property(a => a.CreatedUserId).IsRequired().HasColumnName("created_user");
            builder.Property(a => a.CreatedDate).IsRequired().HasColumnName("created_date");
        }
    }
}
