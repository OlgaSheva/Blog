
using FluentValidation;

namespace Blog.Services.Modules.CommentManagement
{
    class UpdateCommentRequestValidator : AbstractValidator<UpdateCommentRequest>
    {
        public UpdateCommentRequestValidator()
        {
            RuleFor(r => r.Body).MaximumLength(200);
        }
    }
}
