using DotNetPocModels.Models;
using DotNetPocRepositories.Interface;
using DotNetPocRepositories.Repository;
using DotNetPocServices.Interface;
using DotNetPocServices.Service;

namespace DotNetPocAPI
{

    public static class ServiceRegisterExtention
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<ICommentService, CommentService>();

            services.AddSingleton<ICommentRepository, CommentRepository>();

            services.AddSingleton<IReplyService, ReplyService>();

            services.AddSingleton<IReplyRepository, ReplyRepository>();

            services.AddSingleton<IProjectService, ProjectService>();

            services.AddSingleton<IProjectRepository, ProjectRepository>();

            services.AddSingleton<IElementService, ElementService>();

            services.AddSingleton<IElementRepository, ElementRepository>();

            services.AddSingleton<ISlateService, SlateService>();

            services.AddSingleton<ISlateRepository, SlateRepository>();

           // services.AddSingleton<IEmployeeDatabaseSettings, ElementDatabaseSettings>();


            return services;
        }

    }
    
}
