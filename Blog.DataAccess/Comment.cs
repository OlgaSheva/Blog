using System;

namespace Blog.DataAccess
{
    public class Comment
    {
        public string Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastUpdatedDate { get; set; }

        public string Body { get; set; }

        public string ArticleId { get; set; }

        public string AuthorId { get; set; }
    }
}
