using Autofac;

namespace Blog.DataAccess
{
    /// <summary>
    /// Represents an assembly dependency registration <see cref="Module"/>.
    /// </summary>
    public sealed class DependencyRegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationDbContext>().InstancePerRequest();
            builder.RegisterType<Articles.ArticleContext>().As<Articles.IArticleContext>().InstancePerRequest();
            builder.RegisterType<Comments.CommentContext>().As<Comments.ICommentContext>().InstancePerRequest();
            //builder.RegisterType<DebugDatabaseLogger>().As<IDatabaseLogger>();
        }
    }
}
