namespace Blog.DataAccess.Articles
{
    /// <summary>
    /// A context for article domain.
    /// </summary>
    internal sealed class ArticleContext : DomainContextBase<ApplicationDbContext>, IArticleContext
    {
        public ArticleContext(ApplicationDbContext dbContext)
            : base (dbContext)
        {
        }

        public IEntitySet<Article> Articles => GetDbSet<Article>();
    }
}
