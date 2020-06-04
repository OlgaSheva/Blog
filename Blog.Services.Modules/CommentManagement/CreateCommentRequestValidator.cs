using FluentValidation;

namespace Blog.Services.Modules.CommentManagement
{
    public class CreateCommentRequestValidator : AbstractValidator<CreateCommentRequest>
    {
        public CreateCommentRequestValidator()
        {
            RuleFor(r => r.ArticleId).NotEmpty();
            RuleFor(r => r.AuthorId).NotEmpty();
            RuleFor(r => r.Body).MaximumLength(200);
        }
    }
}
