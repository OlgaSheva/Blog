namespace Blog.DataAccess.Comments
{
    /// <summary>
    /// Represents a context for comment domain.
    /// </summary>
    public interface ICommentContext
    {
        /// <summary>
        /// Gets a set of <see cref="Comment"/> entities.
        /// </summary>
        IEntitySet<Comment> Comments { get; }
    }
}
