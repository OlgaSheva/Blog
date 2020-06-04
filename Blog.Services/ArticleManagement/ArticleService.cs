using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Blog.DataAccess.Articles;
using Blog.DataAccess.Comments;
using Blog.Services.Exceptions;
using Blog.Services.Modules.ArticleManagement;
using Microsoft.EntityFrameworkCore;
using Article = Blog.Services.Modules.ArticleManagement.Article;
using DbArticle = Blog.DataAccess.Articles.Article;

namespace Blog.Services.ArticleManagement
{
    /// <summary>
    /// Represents an article service.
    /// </summary>
    public class ArticleService : IArticleService
    {
        private readonly IArticleContext _articles;
        //private readonly ICommentContext _comments;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleService"/> class with specified <see cref="IArticleContext"/> and <see cref="IMapper"/>.
        /// </summary>
        /// <param name="articleContext">A <see cref="IArticleContext"/>.</param>
        /// <param name="mapper">A <see cref="IMapper"/>.</param>
        public ArticleService(IArticleContext articleContext, /*ICommentContext commentContext,*/ IMapper mapper)
        {
            _articles = articleContext ?? throw new ArgumentNullException(nameof(articleContext));
            //_comments = commentContext ?? throw new ArgumentNullException(nameof(commentContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <inheritdoc/>
        public async Task<List<ArticleListItem>> GetArticlesAsync()
        {
            var dbArticles = await _articles.Articles.AsQueryable().OrderBy(article => article.Id).ToArrayAsync();
            var articleListItems = dbArticles.Select(article => Mapper.Map<ArticleListItem>(article)).ToList();
            return articleListItems;
        }

        /// <inheritdoc/>
        public async Task<Article> GetArticleAsync(int id)
        {
            var dbArticles = await _articles.Articles.Where(article => article.Id == id).ToArrayAsync();
            if (dbArticles.Length == 0)
            {
                throw new RequestedResourceNotFoundException();
            }

            return _mapper.Map<DbArticle, Article>(dbArticles[0]);
        }

        /// <inheritdoc/>
        public async Task<Article> CreateArticleAsync(CreateArticleRequest createRequest)
        {
            var dbArticles = await _articles.Articles.Where(article => article.Title == createRequest.Title).ToArrayAsync();
            if (dbArticles.Length > 0)
            {
                throw new RequestedResourceHasConflictException("title");
            }

            var dbArticle = _mapper.Map<CreateArticleRequest, DbArticle>(createRequest);
            dbArticle.CreatedDate = DateTime.Now;
            _articles.Articles.Add(dbArticle);

            await _articles.SaveChangesAsync();

            return _mapper.Map<Article>(dbArticle);
        }

        /// <inheritdoc/>
        public async Task<Article> UpdateArticleAsync(int id, UpdateArticleRequest updateRequest)
        {
            var dbArticles = await _articles.Articles.Where(article => article.Id != id).ToArrayAsync();
            if (dbArticles.Length == 0)
            {
                throw new RequestedResourceNotFoundException();
            }

            if (_articles.Articles.Where(article => article.Title == updateRequest.Title).ToArrayAsync().Result.Length > 0)
            {
                throw new RequestedResourceHasConflictException("title");
            }            

            var dbArticle = dbArticles[0];
            _mapper.Map(updateRequest, dbArticle);

            await _articles.SaveChangesAsync();

            return _mapper.Map<Article>(dbArticle);
        }

        /// <inheritdoc/>
        public async Task DeleteArticleAsync(int id)
        {
            var dbArticles = await _articles.Articles.Where(article => article.Id == id).ToArrayAsync();
            if (dbArticles.Length == 0)
            {
                throw new RequestedResourceNotFoundException();
            }

            var dbArticle = dbArticles[0];
            _articles.Articles.Remove(dbArticle);

            await _articles.SaveChangesAsync();

            // TODO: Попробовать реализовать через события
            //var dbComments = await _comments.Comments.Where(comment => comment.ArticleId == id).ToArrayAsync();
            //foreach (var comment in dbComments)
            //{
            //    _comments.Comments.Remove(comment);
            //}

            //await _comments.SaveChangesAsync();
        }
    }
}
