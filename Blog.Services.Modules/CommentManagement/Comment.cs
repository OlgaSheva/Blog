using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Services.Modules.CommentManagement
{
    /// <summary>
    /// Represents a comment.
    /// </summary>
    public class Comment
    {
        public int Id { get; set; }

        public string Body { get; set; }

        public int ArticleId { get; set; }

        public int CreatedUserId { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
