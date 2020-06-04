using ServiceStack.FluentValidation.Attributes;

namespace Blog.Services.Modules.CommentManagement
{
    [Validator(typeof(UpdateCommentRequestValidator))]
    public class UpdateCommentRequest
    {
        public string Body { get; set; }
    }
}
