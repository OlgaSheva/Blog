namespace Blog.DataAccess.Comments
{
    /// <summary>
    /// A context for comment domain.
    /// </summary>
    internal sealed class CommentContext : DomainContextBase<ApplicationDbContext>, ICommentContext
    {
        public CommentContext(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }

        public IEntitySet<Comment> Comments => GetDbSet<Comment>();
    }
}
