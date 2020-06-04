namespace Blog.DataAccess.Comments
{
    /// <summary>
    /// Represents a context for comment domain.
    /// </summary>
    public interface ICommentContext : IAsyncEntityStorage
    {
        /// <summary>
        /// Gets a set of <see cref="Comment"/> entities.
        /// </summary>
        IEntitySet<Comment> Comments { get; }
    }
}
