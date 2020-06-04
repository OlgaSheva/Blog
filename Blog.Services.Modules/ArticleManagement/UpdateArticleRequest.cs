using ServiceStack.FluentValidation.Attributes;

namespace Blog.Services.Modules.ArticleManagement
{
    /// <summary>
    /// Represents a request for creating and updating an article.
    /// </summary>
    [Validator(typeof(UpdateArticleRequestValidator))]
    public class UpdateArticleRequest
    {
        public string Title { get; set; }

        public string Body { get; set; }
    }
}
