using ServiceStack.FluentValidation.Attributes;
using System;

namespace Blog.Services.Modules.ArticleManagement
{
    [Validator(typeof(CreateArticleRequestValidator))]
    public class CreateArticleRequest
    {
        public string Title { get; set; }

        public string Body { get; set; }

        public string CreatedUser { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
