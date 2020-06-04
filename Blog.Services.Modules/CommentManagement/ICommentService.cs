using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Services.Modules.CommentManagement
{
    /// <summary>
    /// Represents a comment service.
    /// </summary>
    public interface ICommentService
    {
        /// <summary>
        /// Gets a comment list.
        /// </summary>
        /// <returns>A <see cref="Task{List{Comment}}"/>.</returns>
        Task<List<Comment>> GetCommentsAsync();

        /// <summary>
        /// Gets a comment with specified identifier.
        /// </summary>
        /// <param name="id">An comment identifier.</param>
        /// <returns>A <see cref="Task{Comment}"/>.</returns>
        Task<Comment> GetCommentAsync(int id);

        /// <summary>
        /// Creates a new comment.
        /// </summary>
        /// <param name="createRequest">A <see cref="UpdateCommentRequest"/>.</param>
        /// <returns>A <see cref="Task{Comment}"/>.</returns>
        Task<Comment> CreateCommentAsync(CreateCommentRequest createRequest);

        /// <summary>
        /// Updates an existed comment.
        /// </summary>
        /// <param name="id">An comment identifier.</param>
        /// <param name="updateRequest">A <see cref="UpdateCommentRequest"/>.</param>
        /// <returns>A <see cref="Task{Comment}"/>.</returns>
        Task<Comment> UpdateCommentAsync(int id, UpdateCommentRequest updateRequest);

        /// <summary>
        /// Deletes an existed comment.
        /// </summary>
        /// <param name="id">A comment identifier.</param>
        /// <returns>A <see cref="Task"/>.</returns>
        Task DeleteCommentAsync(int id);
    }
}
