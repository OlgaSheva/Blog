namespace Blog.DataAccess.Articles
{
    /// <summary>
    /// Represents a context for article domain.
    /// </summary>
    public interface IArticleContext : IAsyncEntityStorage
    {
        /// <summary>
        /// Gets a set of <see cref="Article"/> entities.
        /// </summary>
        IEntitySet<Article> Articles { get; }
    }
}
