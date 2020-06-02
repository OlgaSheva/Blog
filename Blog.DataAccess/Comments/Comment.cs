using System;

namespace Blog.DataAccess.Comments
{
    public class Comment
    {
        public int Id { get; set; }

        public string Body { get; set; }

        public int ArticleId { get; set; }

        public int CreatedUserId { get; set; }

        public DateTime CreatedDate { get; set; }

        //public DateTime LastUpdatedDate { get; set; }
    }
}
