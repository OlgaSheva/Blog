﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Services.Modules.ArticleManagement
{
    /// <summary>
    /// Represents an article.
    /// </summary>
    public class Article
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public int CreatedUserId { get; set; }

        public DateTime CreatedDate { get; set; }

        //public DateTime LastUpdatedDate { get; set; }
    }
}
