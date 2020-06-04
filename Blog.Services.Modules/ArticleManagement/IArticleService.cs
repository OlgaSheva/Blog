using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Services.Modules.ArticleManagement
{
    /// <summary>
    /// Represents an article service.
    /// </summary>
    public interface IArticleService
    {
        /// <summary>
        /// Gets an articles list.
        /// </summary>
        /// <returns>A <see cref="Task{List{ArticleListItem}}"/>.</returns>
        Task<List<ArticleListItem>> GetArticlesAsync();

        /// <summary>
        /// Gets an article with specified identifier.
        /// </summary>
        /// <param name="id">An article identifier.</param>
        /// <returns>A <see cref="Task{Article}"/>.</returns>
        Task<Article> GetArticleAsync(int id);

        /// <summary>
        /// Creates a new article.
        /// </summary>
        /// <param name="createRequest">A <see cref="UpdateArticleRequest"/>.</param>
        /// <returns>A <see cref="Task{Article}"/>.</returns>
        Task<Article> CreateArticleAsync(CreateArticleRequest createRequest);

        /// <summary>
        /// Updates an existed article.
        /// </summary>
        /// <param name="id">An article identifier.</param>
        /// <param name="updateRequest">A <see cref="UpdateArticleRequest"/>.</param>
        /// <returns>A <see cref="Task{Article}"/>.</returns>
        Task<Article> UpdateArticleAsync(int id, UpdateArticleRequest updateRequest);

        /// <summary>
        /// Deletes an existed article.
        /// </summary>
        /// <param name="id">An article identifier.</param>
        /// <returns>A <see cref="Task"/>.</returns>
        Task DeleteArticleAsync(int id);
    }
}
