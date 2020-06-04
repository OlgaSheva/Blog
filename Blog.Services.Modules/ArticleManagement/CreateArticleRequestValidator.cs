using FluentValidation;
using System;

namespace Blog.Services.Modules.ArticleManagement
{
    public class CreateArticleRequestValidator : AbstractValidator<CreateArticleRequest>
    {
        public CreateArticleRequestValidator()
        {
            RuleFor(r => r.Title).Length(4, 60);
            RuleFor(r => r.Body).MaximumLength(2000);
            RuleFor(r => r.CreatedUser).NotEmpty();
            RuleFor(r => r.CreatedDate).LessThanOrEqualTo(DateTime.Today);
        }
    }
}
