using FluentValidation;

namespace Blog.Services.Modules.ArticleManagement
{
    /// <summary>
    /// Represents a validator for <see cref="UpdateArticleRequestValidator"/>
    /// </summary>
    public class UpdateArticleRequestValidator : AbstractValidator<UpdateArticleRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateArticleRequestValidator"/> class.
        /// </summary>
        public UpdateArticleRequestValidator()
        {
            RuleFor(r => r.Title).Length(4, 60);
            RuleFor(a => a.Body).MaximumLength(2000);
        }
    }
}
