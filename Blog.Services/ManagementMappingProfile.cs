using AutoMapper;
using Blog.Services.Modules.ArticleManagement;
using Blog.Services.Modules.CommentManagement;
using Article = Blog.Services.Modules.ArticleManagement.Article;
using Comment = Blog.Services.Modules.CommentManagement.Comment;
using DataAccessArticle = Blog.DataAccess.Articles.Article;
using DataAccessComment = Blog.DataAccess.Comments.Comment;

namespace Blog.Services
{
    public class ManagementMappingProfile : Profile
    {
        public ManagementMappingProfile()
        {
            CreateMap<DataAccessArticle, Article>();
            CreateMap<UpdateArticleRequest, Article>();
            CreateMap<CreateArticleRequest, Article>();
            CreateMap<ArticleListItem, Article>();
            
            CreateMap<DataAccessComment, Comment>();
            CreateMap<UpdateCommentRequest, Comment>();
            CreateMap<CreateCommentRequest, Comment>();
        }
    }
}
