using ServiceStack.FluentValidation.Attributes;
using System;

namespace Blog.Services.Modules.CommentManagement
{
    [Validator(typeof(CreateCommentRequestValidator))]
    public class CreateCommentRequest
    {
        public string Body { get; set; }

        public string ArticleId { get; set; }

        public string AuthorId { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
